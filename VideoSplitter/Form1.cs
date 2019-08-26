﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;

namespace VideoSplitter
{
    public partial class Form1 : Form
    {
        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public string OpenFile = string.Empty;
        public Form1()
        {
            if (!DesignMode)
            {
                Core.Initialize();
            }
            InitializeComponent();
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mp;
        }
        public bool IsLoading = false;

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    OpenFile = ofd.FileName;
                    lstChapters.Items.Clear();
                    _mp.Stop();
                    _mp.Media = null;
                    try
                    {
                        IsLoading = true;
                        _mp.Play(new Media(_libVLC, OpenFile, FromType.FromPath));
                        System.Threading.Thread.Sleep(500);
                        while (!_mp.IsPlaying)
                        {
                            Application.DoEvents();
                        }
                        _mp.Pause();
                        int chapCount = _mp.ChapterCount;
                        for (int i = 0; i < chapCount - 1; ++i)
                        {
                            long time = _mp.Time;
                            _mp.Chapter = i;
                            while (time == _mp.Time)
                            {
                                Application.DoEvents();
                            }
                            lstChapters.Items.Add(_mp.Time);
                        }

                        _mp.Chapter = 0;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    finally
                    {
                        IsLoading = false;
                    }
                }

            }
        }

        private void LstChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading)
            {
                return;
            }
            if (!_mp.IsSeekable)
            {
                _mp.Play(new Media(_libVLC, OpenFile, FromType.FromPath));
                while (!_mp.IsPlaying)
                {
                    Application.DoEvents();
                }
            }

            long time = long.Parse(lstChapters.SelectedItem.ToString());
            _mp.Time = time;
            if (!_mp.IsPlaying)
            {
                _mp.Pause();
            }
        }

        private class Segment
        {
            public const long MS_TO_CUT_END = 100;
            public string StartTimeSeconds
            {
                get
                {
                    return (((decimal)StartTime) / 1000).ToString();
                }
            }

            public string DurationSeconds
            {
                get
                {
                    return (((decimal)Duration) / 1000).ToString();
                }
            }
            public long StartTime { get; set; }
            public long EndTime { get; set; }
            public long Duration
            {
                get
                {
                    return (EndTime - StartTime) - MS_TO_CUT_END;
                }
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_mp.Length == -1)
            {
                return;
            }
            List<Segment> msTimes = new List<Segment>();
            long lastTime = 0;
            foreach (object checkedItem in lstChapters.CheckedItems)
            {
                long thisTime = long.Parse(checkedItem.ToString());
                if (thisTime == lastTime)
                {
                    continue;
                }
                Segment newSeg = new Segment();
                newSeg.StartTime = lastTime;
                newSeg.EndTime = thisTime;
                msTimes.Add(newSeg);
                lastTime = thisTime;
            }
            if (lastTime != _mp.Length)
            {
                Segment finalseg = new Segment();
                finalseg.StartTime = lastTime;
                finalseg.EndTime = _mp.Length;
                msTimes.Add(finalseg);
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("REM This script will split up the files into the selected chapters");
            int segCount = 0;
            foreach (Segment seg in msTimes)
            {
                sb.AppendFormat("ffmpeg -i \"{0}\" -ss {1} -t {2} -c copy -reset_timestamps 1 \"segment {3}.mkv\"\r\n", OpenFile, seg.StartTimeSeconds, seg.DurationSeconds, segCount);
                segCount++;
            }
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Batch File|*.bat";
                sfd.FileName = "Split.bat";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.TextWriter tw = System.IO.File.CreateText(sfd.FileName))
                    {
                        tw.Write(sb.ToString());
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mp.Stop();
        }
    }
}