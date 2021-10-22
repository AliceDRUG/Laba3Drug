using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Laba3Drug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GraphPane graphfield = zedGraphControl1.GraphPane;
            // Цвет рамки для всего компонента
            graphfield.Border.Color = Color.FromArgb(168,0, 219);
            // Цвет рамки вокруг графика
            graphfield.Chart.Border.Color = Color.FromArgb(168, 0, 219);
            // Цвет рамки графика
            graphfield.Fill.Type = FillType.Solid;
            graphfield.Fill.Color = Color.FromArgb(86, 19, 148);
            // Фон графика
            graphfield.Chart.Fill.Type = FillType.Solid;
            graphfield.Chart.Fill.Color = Color.FromArgb(209, 153, 255);
            // Показ оси на уровне X = 0 и Y = 0
            graphfield.XAxis.MajorGrid.IsZeroLine = true;
            graphfield.YAxis.MajorGrid.IsZeroLine = true;
            // Цвет осей
            graphfield.XAxis.Color = Color.Black;
            graphfield.YAxis.Color = Color.Black;
            // Включим сетку
            graphfield.XAxis.MajorGrid.IsVisible = true;
            graphfield.YAxis.MajorGrid.IsVisible = true;
            // Цвет для сетки
            graphfield.XAxis.MajorGrid.Color = Color.FromArgb(0, 0, 0);
            graphfield.YAxis.MajorGrid.Color = Color.FromArgb(0, 0, 0);
            // Цвет для подписей рядом с осями
            graphfield.XAxis.Title.FontSpec.FontColor = Color.FromArgb(232, 204, 255);
            graphfield.YAxis.Title.FontSpec.FontColor = Color.FromArgb(232, 204, 255);
            // Цвет подписей под метками
            graphfield.XAxis.Scale.FontSpec.FontColor = Color.FromArgb(232, 204, 255);
            graphfield.YAxis.Scale.FontSpec.FontColor = Color.FromArgb(232, 204, 255);
            // Цвет заголовка над графиком
            graphfield.Title.FontSpec.FontColor = Color.FromArgb(232, 204, 255);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private async void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
