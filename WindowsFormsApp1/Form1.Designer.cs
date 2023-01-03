
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.condition = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.windspeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.location = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // condition
            // 
            this.condition.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.condition, "condition");
            this.condition.ForeColor = System.Drawing.SystemColors.Control;
            this.condition.Name = "condition";
            // 
            // cityTextBox
            // 
            resources.ApplyResources(this.cityTextBox, "cityTextBox");
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.UseWaitCursor = true;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.search, "search");
            this.search.Name = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.details, "details");
            this.details.ForeColor = System.Drawing.SystemColors.Control;
            this.details.Name = "details";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Name = "label4";
            // 
            // sunset
            // 
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.sunset, "sunset");
            this.sunset.ForeColor = System.Drawing.SystemColors.Control;
            this.sunset.Name = "sunset";
            // 
            // sunrise
            // 
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.sunrise, "sunrise");
            this.sunrise.ForeColor = System.Drawing.SystemColors.Control;
            this.sunrise.Name = "sunrise";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Name = "label7";
            // 
            // windspeed
            // 
            this.windspeed.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.windspeed, "windspeed");
            this.windspeed.ForeColor = System.Drawing.SystemColors.Control;
            this.windspeed.Name = "windspeed";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Name = "label9";
            // 
            // pressure
            // 
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pressure, "pressure");
            this.pressure.ForeColor = System.Drawing.SystemColors.Control;
            this.pressure.Name = "pressure";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picIcon, "picIcon");
            this.picIcon.Name = "picIcon";
            this.picIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.condition);
            this.panel1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // location
            // 
            resources.ApplyResources(this.location, "location");
            this.location.BackColor = System.Drawing.Color.Transparent;
            this.location.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.location.Name = "location";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.location);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.details);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cityTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label windspeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label location;
    }
}

