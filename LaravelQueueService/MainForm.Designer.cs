namespace LaravelQueueService
{
    partial class MainForm
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
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceName = new System.Windows.Forms.Label();
            this.serviceDescription = new System.Windows.Forms.Label();
            this.serviceDisplayName = new System.Windows.Forms.Label();
            this.phpPath = new System.Windows.Forms.Label();
            this.laravelPath = new System.Windows.Forms.Label();
            this.adminAlert = new System.Windows.Forms.Label();
            this.arguments = new System.Windows.Forms.Label();
            this.runningStatus = new System.Windows.Forms.Label();
            this.fullCommandLabel = new System.Windows.Forms.Label();
            this.serviceLogLabel = new System.Windows.Forms.Label();
            this.comandLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.serviceStatusLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(34, 529);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(150, 67);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Install Service";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.InstallButtonClick);
            // 
            // uninstallButton
            // 
            this.uninstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallButton.Location = new System.Drawing.Point(209, 530);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(186, 66);
            this.uninstallButton.TabIndex = 1;
            this.uninstallButton.Text = "Uninstall Service";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.UninstallButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Windows Service For Laravel Queue";
            // 
            // serviceName
            // 
            this.serviceName.AutoSize = true;
            this.serviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceName.Location = new System.Drawing.Point(31, 268);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(124, 20);
            this.serviceName.TabIndex = 3;
            this.serviceName.Text = "Service Name:";
            // 
            // serviceDescription
            // 
            this.serviceDescription.AutoSize = true;
            this.serviceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceDescription.Location = new System.Drawing.Point(30, 297);
            this.serviceDescription.Name = "serviceDescription";
            this.serviceDescription.Size = new System.Drawing.Size(169, 20);
            this.serviceDescription.TabIndex = 4;
            this.serviceDescription.Text = "Service Description:";
            // 
            // serviceDisplayName
            // 
            this.serviceDisplayName.AutoSize = true;
            this.serviceDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceDisplayName.Location = new System.Drawing.Point(30, 329);
            this.serviceDisplayName.Name = "serviceDisplayName";
            this.serviceDisplayName.Size = new System.Drawing.Size(123, 20);
            this.serviceDisplayName.TabIndex = 5;
            this.serviceDisplayName.Text = "Display Name:";
            // 
            // phpPath
            // 
            this.phpPath.AutoSize = true;
            this.phpPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phpPath.Location = new System.Drawing.Point(30, 362);
            this.phpPath.Name = "phpPath";
            this.phpPath.Size = new System.Drawing.Size(90, 20);
            this.phpPath.TabIndex = 6;
            this.phpPath.Text = "PHP path:";
            // 
            // laravelPath
            // 
            this.laravelPath.AutoSize = true;
            this.laravelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laravelPath.Location = new System.Drawing.Point(31, 397);
            this.laravelPath.Name = "laravelPath";
            this.laravelPath.Size = new System.Drawing.Size(109, 20);
            this.laravelPath.TabIndex = 7;
            this.laravelPath.Text = "LaravelPath:";
            // 
            // adminAlert
            // 
            this.adminAlert.AutoSize = true;
            this.adminAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAlert.ForeColor = System.Drawing.Color.Red;
            this.adminAlert.Location = new System.Drawing.Point(326, 111);
            this.adminAlert.Name = "adminAlert";
            this.adminAlert.Size = new System.Drawing.Size(259, 29);
            this.adminAlert.TabIndex = 8;
            this.adminAlert.Text = "Run as administrator!";
            // 
            // arguments
            // 
            this.arguments.AutoSize = true;
            this.arguments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arguments.Location = new System.Drawing.Point(31, 427);
            this.arguments.Name = "arguments";
            this.arguments.Size = new System.Drawing.Size(101, 20);
            this.arguments.TabIndex = 10;
            this.arguments.Text = "Arguments:";
            // 
            // runningStatus
            // 
            this.runningStatus.AutoSize = true;
            this.runningStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningStatus.Location = new System.Drawing.Point(31, 198);
            this.runningStatus.Name = "runningStatus";
            this.runningStatus.Size = new System.Drawing.Size(148, 24);
            this.runningStatus.TabIndex = 11;
            this.runningStatus.Text = "Service Status:";
            // 
            // fullCommandLabel
            // 
            this.fullCommandLabel.AutoSize = true;
            this.fullCommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullCommandLabel.Location = new System.Drawing.Point(31, 237);
            this.fullCommandLabel.Name = "fullCommandLabel";
            this.fullCommandLabel.Size = new System.Drawing.Size(94, 20);
            this.fullCommandLabel.TabIndex = 12;
            this.fullCommandLabel.Text = "Command:";
            // 
            // serviceLogLabel
            // 
            this.serviceLogLabel.AutoSize = true;
            this.serviceLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLogLabel.Location = new System.Drawing.Point(31, 458);
            this.serviceLogLabel.Name = "serviceLogLabel";
            this.serviceLogLabel.Size = new System.Drawing.Size(108, 20);
            this.serviceLogLabel.TabIndex = 13;
            this.serviceLogLabel.Text = "Service Log:";
            // 
            // comandLabel
            // 
            this.comandLabel.AutoSize = true;
            this.comandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comandLabel.Location = new System.Drawing.Point(131, 237);
            this.comandLabel.Name = "comandLabel";
            this.comandLabel.Size = new System.Drawing.Size(121, 20);
            this.comandLabel.TabIndex = 14;
            this.comandLabel.Text = "CommandLabel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(145, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(451, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "storage/logs/windows-service-LaravelQueueService-{$date}.log";
            // 
            // serviceStatusLabel
            // 
            this.serviceStatusLabel.AutoSize = true;
            this.serviceStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceStatusLabel.Location = new System.Drawing.Point(185, 198);
            this.serviceStatusLabel.Name = "serviceStatusLabel";
            this.serviceStatusLabel.Size = new System.Drawing.Size(60, 24);
            this.serviceStatusLabel.TabIndex = 22;
            this.serviceStatusLabel.Text = "label2";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(14, 631);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(139, 24);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Laravel Module";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(641, 631);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(254, 25);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Created by Litiano Moura";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(753, 673);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(67, 20);
            this.versionLabel.TabIndex = 26;
            this.versionLabel.Text = "Version:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(159, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = global::LaravelQueueService.Properties.Settings.Default.service_name;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = global::LaravelQueueService.Properties.Settings.Default.service_description;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = global::LaravelQueueService.Properties.Settings.Default.service_display_name;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = global::LaravelQueueService.Properties.Settings.Default.php_path;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = global::LaravelQueueService.Properties.Settings.Default.laravel_base_path;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = global::LaravelQueueService.Properties.Settings.Default.queue_work_arguments;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 702);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.serviceStatusLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comandLabel);
            this.Controls.Add(this.fullCommandLabel);
            this.Controls.Add(this.serviceLogLabel);
            this.Controls.Add(this.runningStatus);
            this.Controls.Add(this.arguments);
            this.Controls.Add(this.adminAlert);
            this.Controls.Add(this.laravelPath);
            this.Controls.Add(this.phpPath);
            this.Controls.Add(this.serviceDisplayName);
            this.Controls.Add(this.serviceDescription);
            this.Controls.Add(this.serviceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.installButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Windows Service For Laravel Queue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serviceName;
        private System.Windows.Forms.Label serviceDescription;
        private System.Windows.Forms.Label serviceDisplayName;
        private System.Windows.Forms.Label phpPath;
        private System.Windows.Forms.Label laravelPath;
        private System.Windows.Forms.Label adminAlert;
        private System.Windows.Forms.Label arguments;
        private System.Windows.Forms.Label runningStatus;
        private System.Windows.Forms.Label fullCommandLabel;
        private System.Windows.Forms.Label serviceLogLabel;
        private System.Windows.Forms.Label comandLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label serviceStatusLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label versionLabel;
    }
}