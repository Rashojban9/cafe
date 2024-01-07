using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bislerium_cafe
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            InitializeItemPanels();
        }

        private void InitializeItemPanels()
        {
            // Assume you have a list of items or data
            string[] itemNames = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
            decimal[] itemPrices = { 10.99m, 24.99m, 15.49m, 8.99m, 19.99m };
            string[] imagePaths = { "path1.jpg", "path2.jpg", "path3.jpg", "path4.jpg", "path5.jpg" };

            for (int i = 0; i < itemNames.Length; i++)
            {
                Panel itemPanel = CreateItemPanel(itemNames[i], itemPrices[i], imagePaths[i]);
                flowLayoutPanel1.Controls.Add(itemPanel);
            }
        }

        private Panel CreateItemPanel(string itemName, decimal itemPrice, string imagePath)
        {
            Panel panel = new Panel();
            panel.Size = new Size(200, 120);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Margin = new Padding(10);

            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Size = new Size(80, 80);
            //pictureBox.Location = new Point(10, 10);
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox.Image = Image.FromFile(imagePath); // Load image from file

            Label nameLabel = new Label();
            nameLabel.Text = itemName;
            nameLabel.Location = new Point(100, 10);
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);

            Label priceLabel = new Label();
            priceLabel.Text = $"Price: ${itemPrice:F2}";
            priceLabel.Location = new Point(100, 40);
            priceLabel.AutoSize = true;

            panel.Click += (sender, e) =>
            {
                MessageBox.Show($"Item: {itemName}\nPrice: ${itemPrice:F2}");
            };

            //panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);

            return panel;
        }
    }
}

