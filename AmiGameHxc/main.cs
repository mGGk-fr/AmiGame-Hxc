﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiGameHxc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            browser.ShowDialog();
            tb_adfDir.Text = browser.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_gameList.Items.Clear();
            string tempCurrentGame = "";
            string tempScannedGameName = "";

            List<Game> gameList = new List<Game>();
            DirectoryInfo workDir = new DirectoryInfo(tb_adfDir.Text);
            foreach (var file in workDir.GetFiles("*.hfe"))
            {
                tempScannedGameName = getCleanDiskFileName(file.Name);
                if(tempScannedGameName == tempCurrentGame)
                {
                    gameList[gameList.Count - 1].addDiskFile(file.Name);
                }
                else
                {
                    gameList.Add(new Game(tempScannedGameName, file.Name));
                    tempCurrentGame = tempScannedGameName;
                }
            }

            foreach(Game curGame in gameList)
            {
                if(curGame.getNumberOfDisk() == 1)
                {
                    File.Copy(this.tb_adfDir.Text + "\\" + curGame.getFileDiskList()[0], this.tb_outDir.Text + "\\" + curGame.getGameName()+".hfe");
                }
                else
                {
                    Directory.CreateDirectory(this.tb_outDir.Text + "\\" + curGame.getGameName());
                    foreach(string diskFile in curGame.getFileDiskList())
                    {
                        File.Copy(this.tb_adfDir.Text + "\\" + diskFile, this.tb_outDir.Text + "\\" + curGame.getGameName() + "\\" + getDiskNumber(diskFile)+".hfe");
                    }
                }
                lb_gameList.Items.Add(curGame.getGameName());
            }
            MessageBox.Show("Job Done !");
        }

        private string getCleanDiskFileName(string fileName)
        {
            string[] splittedFileName = fileName.Split('(');
            return splittedFileName[0].Trim();
        }

        private string getDiskNumber(string fileName)
        {
            string[] fileNameSplitted = fileName.Split('(');
            string[] tempDiskNumber = fileNameSplitted[fileNameSplitted.Length - 1].Split('o');
            return tempDiskNumber[0].Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            browser.ShowDialog();
            tb_outDir.Text = browser.SelectedPath;
        }
    }
}
