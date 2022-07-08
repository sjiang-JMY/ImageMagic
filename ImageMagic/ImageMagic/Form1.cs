using ImageMagic.Utils;
using ImageMagic.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageMagic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetFormatCombaData();
        }

        private void SelectFoler(object sender, EventArgs e)
        {
            FolderBrowserDialog fileFolder = new FolderBrowserDialog();
            if(fileFolder.ShowDialog() == DialogResult.OK)
            {
                this.fromInput.Text = fileFolder.SelectedPath;
            }
        }

        private void outputFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog fileFolder = new FolderBrowserDialog();
            if (fileFolder.ShowDialog() == DialogResult.OK)
            {
                this.outInput.Text = fileFolder.SelectedPath;
            }
        }
         private void GetFormatCombaData()
        {
            List<Info> infos = new List<Info>();
            infos.Add(new Info() { Id = 1, Name = "JPG" });
            infos.Add(new Info() { Id = 2, Name = "PNG" });
            infos.Add(new Info() { Id = 3, Name = "SVG" });
            infos.Add(new Info() { Id = 4, Name = "GIF" });
            this.formatComba.DataSource = infos;
            this.formatComba.ValueMember = "Id";
            this.formatComba.DisplayMember = "Name";
            this.formatComba.SelectedIndex = 0;
        }

        private void widthInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.outInput.Text = string.Empty;
            this.fromInput.Text = string.Empty;
            this.widthInput.Text = string.Empty;
            this.heightInput.Text = string.Empty;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var inputPath = this.fromInput.Text;
            if (string.IsNullOrEmpty(inputPath))
            {
                MessageBox.Show("文件输入路径不能为空");
                return;
            }
            var outputPath = this.outInput.Text;
            if (string.IsNullOrEmpty(outputPath))
            {
                MessageBox.Show("文件输出路径不能为空");
                return;
            }
            var widthConvert = int.TryParse(this.widthInput.Text, out int widthResult);
            if (!widthConvert)
            {
                MessageBox.Show("图片宽度必须为数字整数");
                this.widthInput.ForeColor = System.Drawing.SystemColors.Desktop;
                return;
            }
            var heightConvert = int.TryParse(this.heightInput.Text, out int heightResult);
            if (!heightConvert)
            {
                MessageBox.Show("图片高度必须为数字整数");
                this.heightInput.ForeColor = System.Drawing.SystemColors.Desktop;
                return;
            }
            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                ImageTools.ImageMagic(inputPath, outputPath, widthResult, heightResult, this.formatComba.Text);
                sw.Stop();
                this.consoleBox.Text = "转换成功" + Environment.NewLine + "耗时：" + sw.Elapsed;
                resetBtn_Click(sender, e);
            }
            catch (Exception ex)
            {
                this.consoleBox.Text = ex.Message;
            }
        }
    }
}
