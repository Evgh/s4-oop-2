
namespace s4_oop_2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarWindows = new System.Windows.Forms.TrackBar();
            this.trackBarArea = new System.Windows.Forms.TrackBar();
            this.listBoxRoomOrientation = new System.Windows.Forms.ListBox();
            this.buttonAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelWindows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarArea)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarWindows
            // 
            this.trackBarWindows.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.trackBarWindows.BackColor = System.Drawing.SystemColors.Desktop;
            this.trackBarWindows.Location = new System.Drawing.Point(166, 134);
            this.trackBarWindows.Name = "trackBarWindows";
            this.trackBarWindows.Size = new System.Drawing.Size(257, 56);
            this.trackBarWindows.TabIndex = 1;
            this.trackBarWindows.Scroll += new System.EventHandler(this.trackBarWindows_Scroll);
            // 
            // trackBarArea
            // 
            this.trackBarArea.BackColor = System.Drawing.SystemColors.Desktop;
            this.trackBarArea.Location = new System.Drawing.Point(166, 196);
            this.trackBarArea.Minimum = 1;
            this.trackBarArea.Name = "trackBarArea";
            this.trackBarArea.Size = new System.Drawing.Size(257, 56);
            this.trackBarArea.TabIndex = 2;
            this.trackBarArea.Value = 1;
            this.trackBarArea.Scroll += new System.EventHandler(this.trackBarArea_Scroll);
            // 
            // listBoxRoomOrientation
            // 
            this.listBoxRoomOrientation.FormattingEnabled = true;
            this.listBoxRoomOrientation.ItemHeight = 16;
            this.listBoxRoomOrientation.Location = new System.Drawing.Point(166, 12);
            this.listBoxRoomOrientation.Name = "listBoxRoomOrientation";
            this.listBoxRoomOrientation.Size = new System.Drawing.Size(257, 116);
            this.listBoxRoomOrientation.TabIndex = 3;
            this.listBoxRoomOrientation.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomOrientation_SelectedIndexChanged);
            // 
            // buttonAddButton
            // 
            this.buttonAddButton.Location = new System.Drawing.Point(13, 283);
            this.buttonAddButton.Name = "buttonAddButton";
            this.buttonAddButton.Size = new System.Drawing.Size(147, 23);
            this.buttonAddButton.TabIndex = 4;
            this.buttonAddButton.Text = "Добавить комнату";
            this.buttonAddButton.UseVisualStyleBackColor = true;
            this.buttonAddButton.Click += new System.EventHandler(this.buttonAddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сторона окон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество окон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Площадь, m^2";
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.ItemHeight = 16;
            this.listBoxRooms.Location = new System.Drawing.Point(471, 13);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(511, 244);
            this.listBoxRooms.TabIndex = 8;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(135, 213);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(12, 17);
            this.labelArea.TabIndex = 9;
            this.labelArea.Text = " ";
            this.labelArea.Click += new System.EventHandler(this.labelArea_Click);
            // 
            // labelWindows
            // 
            this.labelWindows.AutoSize = true;
            this.labelWindows.Location = new System.Drawing.Point(135, 151);
            this.labelWindows.Name = "labelWindows";
            this.labelWindows.Size = new System.Drawing.Size(12, 17);
            this.labelWindows.TabIndex = 10;
            this.labelWindows.Text = " ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 320);
            this.Controls.Add(this.labelWindows);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.listBoxRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddButton);
            this.Controls.Add(this.listBoxRoomOrientation);
            this.Controls.Add(this.trackBarArea);
            this.Controls.Add(this.trackBarWindows);
            this.Name = "Form3";
            this.Text = "Список комнат";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarWindows;
        private System.Windows.Forms.TrackBar trackBarArea;
        private System.Windows.Forms.ListBox listBoxRoomOrientation;
        private System.Windows.Forms.Button buttonAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelWindows;
    }
}