using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSale
{
    public partial class FormSeatSelection : Form
    {
        public FormSeatSelection(int _passengerCount)
        {
            InitializeComponent();
            passengerCount = _passengerCount;
        }

        PictureBox pictureBox;
        Label label;
        Button button;
        RadioButton radioButton;
        Panel panel;
        int x1 = 89, x2 = 95, labelSize = 16, passengerCount, selectedSeatCount = 0, panelY = 17;
        string selectedSeatName = null;
        List<string> passengers = new List<string>();

        private void FormSeatSelection_Load(object sender, EventArgs e)
        {
            try
            {
                passengers.Add("Emre Cüni");
                passengers.Add("İbrahim Akı");
                AddSeat();
                AddButton();
                AddPassengersPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Koltuk Seçimi Load Hatası");
            }
        }

        private void SeatSelection_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in panelSeatSelection.Controls) // koltukların olduğu paneldeki bütün tool'lar dönülür
                {
                    PictureBox pictureBoxControl;
                    try
                    {
                        pictureBoxControl = (PictureBox)control; // picturebox olanlar picturebox nesnesine atanır
                        if (pictureBoxControl.Name == selectedSeatName) // bir önceki seçilen koltuğa default değeri atanır.
                        {
                            if ((pictureBoxControl.Name.LastIndexOf("A") >= 11 || pictureBoxControl.Name.LastIndexOf("F") >= 11) && (pictureBoxControl.Name.LastIndexOf("15") == -1 && pictureBoxControl.Name.LastIndexOf("16") == -1))
                                pictureBoxControl.Image = imageListSeats.Images[0];
                            else if ((pictureBoxControl.Name.LastIndexOf("B") >= 11 || pictureBoxControl.Name.LastIndexOf("E") >= 11) && (pictureBoxControl.Name.LastIndexOf("15") == -1 && pictureBoxControl.Name.LastIndexOf("16") == -1))
                                pictureBoxControl.Image = imageListSeats.Images[1];
                            else if ((pictureBoxControl.Name.LastIndexOf("C") >= 11 || pictureBoxControl.Name.LastIndexOf("D") >= 11) && (pictureBoxControl.Name.LastIndexOf("15") == -1 && pictureBoxControl.Name.LastIndexOf("16") == -1))
                                pictureBoxControl.Image = imageListSeats.Images[2];
                            else
                                pictureBoxControl.Image = imageListSeats.Images[3];
                            pictureBoxControl.Image.Tag = false;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }

                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Image.Tag != null && !(bool)pictureBox.Image.Tag) // koltuk boşsa seçili koltuk iconu picturebox'a atanır ve tag değerine dolu değeri verilir
                {
                    pictureBox.Image = imageListSeats.Images[6];
                    pictureBox.Image.Tag = true;
                    selectedSeatName = pictureBox.Name;
                    selectedSeatCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Koltuk Seçimi Hatası");
            }
        }

        private void buttonSaveSelection_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Seçimi Kaydet Hatası");
            }
        }

        private void AddLabel(string text, int x, int y, int size)
        {
            try
            {
                label = new Label();
                label.Text = text;
                label.Location = new Point(x, y);
                label.Size = new Size(size, 18);
                label.Name = "label" + text;
                panelSeatSelection.Controls.Add(label);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Label Ekleme Hatası");
            }
        }

        private void AddSeatPicture(string name, int x, int y, int imageIndex)
        {
            try
            {
                pictureBox = new PictureBox();
                pictureBox.Size = new Size(25, 25);
                pictureBox.Name = name;
                pictureBox.Image = imageListSeats.Images[imageIndex];
                pictureBox.Location = new Point(x, y);
                pictureBox.Image.Tag = false;
                pictureBox.Click += SeatSelection_Click;
                panelSeatSelection.Controls.Add(pictureBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Resim Ekleme Hatası");
            }
        }

        private void AddSeat()
        {
            try
            {
                panelSeatSelection.Controls.Clear();

                x1 = 89;
                x2 = 95;
                labelSize = 16;

                AddLabel("A", 36, 52, 17);
                AddLabel("B", 36, 85, 17);
                AddLabel("C", 36, 118, 17);
                AddLabel("D", 36, 175, 17);
                AddLabel("E", 36, 208, 17);
                AddLabel("F", 36, 241, 17);

                for (int i = 1; i <= 32; i++)
                {
                    if (i > 9)
                        labelSize = 24;

                    AddLabel(i.ToString(), x2, 147, labelSize);

                    if (i == 15 || i == 16) // acil çıkışlar
                    {
                        AddSeatPicture($"pictureBox{i}A", x1, 45, 3);
                        AddSeatPicture($"pictureBox{i}B", x1, 78, 3);
                        AddSeatPicture($"pictureBox{i}C", x1, 111, 3);
                        AddSeatPicture($"pictureBox{i}D", x1, 175, 3);
                        AddSeatPicture($"pictureBox{i}E", x1, 208, 3);
                        AddSeatPicture($"pictureBox{i}F", x1, 241, 3);
                    }
                    else
                    {
                        AddSeatPicture($"pictureBox{i}A", x1, 45, 0);
                        AddSeatPicture($"pictureBox{i}B", x1, 78, 1);
                        AddSeatPicture($"pictureBox{i}C", x1, 111, 2);
                        AddSeatPicture($"pictureBox{i}D", x1, 175, 2);
                        AddSeatPicture($"pictureBox{i}E", x1, 208, 1);
                        AddSeatPicture($"pictureBox{i}F", x1, 241, 0);
                    }

                    x1 += 33;
                    if (i == 9)
                        x2 += 30;
                    else
                        x2 += 33;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Koltuk Ekleme Hatası");
            }
        }

        private void AddButton()
        {
            try
            {
                button = new Button();
                button.Name = "buttonSaveSelection";
                button.Text = "Seçimi Kaydet";
                button.Size = new Size(150, 43);
                button.Location = new Point(1100, 300);
                button.BackColor = Color.DarkGray;
                button.Click += new EventHandler(buttonSaveSelection_Click);

                panelSeatSelection.Controls.Add(button);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Buton Ekleme Hatası");
            }
        }

        private void AddPassengersPanel()
        {
            try
            {
                for (int i = 0; i < passengerCount; i++)
                {
                    panel = new Panel();
                    panel.Name = $"panel{i}";
                    panel.Location = new Point(18, panelY);
                    panel.Size = new Size(1251, 73);
                    panel.BackColor = Color.FromArgb(130, 130, 130);

                    radioButton = new RadioButton();
                    radioButton.Name = $"radioButton{i}";
                    radioButton.Location = new Point(21, 23);
                    radioButton.Size = new Size(150, 29);
                    radioButton.Text = passengers[i];
                    radioButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
                    radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
                    if (i == 0)
                        radioButton.Checked = true;
                    panel.Controls.Add(radioButton);

                    label = new Label();
                    label.Location = new Point(813, 23);
                    label.Size = new Size(172, 24);
                    label.Visible = false;
                    label.Name = $"labelSelectedSeat{i}";
                    panel.Controls.Add(label);

                    label = new Label();
                    label.Location = new Point(1033, 23);
                    label.Size = new Size(66, 24);
                    label.Name = $"labelSeatPrice{i}";
                    label.Visible = false;
                    panel.Controls.Add(label);

                    button = new Button();
                    button.Name = $"buttonCancel{i}";
                    button.Location = new Point(1182, 14);
                    button.Size = new Size(40, 40);
                    button.Text = "X";
                    button.BackColor = Color.Red;
                    button.ForeColor = Color.White;
                    button.Visible = false;
                    button.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
                    panel.Controls.Add(button);

                    panelPassengers.Controls.Add(panel);
                    panelY += 95;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Passengers Panel Hatası");
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "radioButton CheckedChanged Hatası");
            }
        }
    }
}
