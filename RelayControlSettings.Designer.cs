﻿namespace RelayControl
{
    partial class RelayControlSettings
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
            this.grpRelayControlTiming = new System.Windows.Forms.GroupBox();
            this.lblOff_ms = new System.Windows.Forms.Label();
            this.lblOn_ms = new System.Windows.Forms.Label();
            this.lblDelay_ms = new System.Windows.Forms.Label();
            this.txtOff_ms = new System.Windows.Forms.TextBox();
            this.txtOn_ms = new System.Windows.Forms.TextBox();
            this.txtDelay_ms = new System.Windows.Forms.TextBox();
            this.GrpSwMode = new System.Windows.Forms.GroupBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.GrpSwTrigger1 = new System.Windows.Forms.GroupBox();
            this.lblTriggerChannel = new System.Windows.Forms.Label();
            this.lblTriggerEnable = new System.Windows.Forms.Label();
            this.txtTriggerChannel = new System.Windows.Forms.TextBox();
            this.GrpSwSync1 = new System.Windows.Forms.GroupBox();
            this.OptSwAsynchron1 = new System.Windows.Forms.RadioButton();
            this.OptSwSynchron1 = new System.Windows.Forms.RadioButton();
            this.GrpSwImmediate1 = new System.Windows.Forms.GroupBox();
            this.OpSwImmediateOff1 = new System.Windows.Forms.RadioButton();
            this.OpSwImmediateOn1 = new System.Windows.Forms.RadioButton();
            this.GrpSwNegation1 = new System.Windows.Forms.GroupBox();
            this.lblInvertingMode = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpEnable = new System.Windows.Forms.GroupBox();
            this.lblEnable = new System.Windows.Forms.Label();
            this.ledEnable = new Bulb.LedBulb();
            this.ledInvertingMode = new Bulb.LedBulb();
            this.ledTriggerEnable = new Bulb.LedBulb();
            this.grpSignalName = new System.Windows.Forms.GroupBox();
            this.txtSignalName = new System.Windows.Forms.TextBox();
            this.grpRelayControlTiming.SuspendLayout();
            this.GrpSwMode.SuspendLayout();
            this.GrpSwTrigger1.SuspendLayout();
            this.GrpSwSync1.SuspendLayout();
            this.GrpSwImmediate1.SuspendLayout();
            this.GrpSwNegation1.SuspendLayout();
            this.grpEnable.SuspendLayout();
            this.grpSignalName.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRelayControlTiming
            // 
            this.grpRelayControlTiming.Controls.Add(this.lblOff_ms);
            this.grpRelayControlTiming.Controls.Add(this.lblOn_ms);
            this.grpRelayControlTiming.Controls.Add(this.lblDelay_ms);
            this.grpRelayControlTiming.Controls.Add(this.txtOff_ms);
            this.grpRelayControlTiming.Controls.Add(this.txtOn_ms);
            this.grpRelayControlTiming.Controls.Add(this.txtDelay_ms);
            this.grpRelayControlTiming.Location = new System.Drawing.Point(358, 108);
            this.grpRelayControlTiming.Margin = new System.Windows.Forms.Padding(4);
            this.grpRelayControlTiming.Name = "grpRelayControlTiming";
            this.grpRelayControlTiming.Padding = new System.Windows.Forms.Padding(4);
            this.grpRelayControlTiming.Size = new System.Drawing.Size(195, 281);
            this.grpRelayControlTiming.TabIndex = 15;
            this.grpRelayControlTiming.TabStop = false;
            this.grpRelayControlTiming.Text = "Zeiteinstellungen";
            // 
            // lblOff_ms
            // 
            this.lblOff_ms.BackColor = System.Drawing.Color.Transparent;
            this.lblOff_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOff_ms.Location = new System.Drawing.Point(29, 195);
            this.lblOff_ms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOff_ms.Name = "lblOff_ms";
            this.lblOff_ms.Size = new System.Drawing.Size(137, 20);
            this.lblOff_ms.TabIndex = 20;
            this.lblOff_ms.Text = "Ausschaltzeit [ms]";
            this.lblOff_ms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOn_ms
            // 
            this.lblOn_ms.BackColor = System.Drawing.Color.Transparent;
            this.lblOn_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOn_ms.Location = new System.Drawing.Point(31, 124);
            this.lblOn_ms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOn_ms.Name = "lblOn_ms";
            this.lblOn_ms.Size = new System.Drawing.Size(132, 20);
            this.lblOn_ms.TabIndex = 19;
            this.lblOn_ms.Text = "Einschaltzeit [ms]";
            this.lblOn_ms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelay_ms
            // 
            this.lblDelay_ms.BackColor = System.Drawing.Color.Transparent;
            this.lblDelay_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelay_ms.Location = new System.Drawing.Point(14, 52);
            this.lblDelay_ms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay_ms.Name = "lblDelay_ms";
            this.lblDelay_ms.Size = new System.Drawing.Size(167, 20);
            this.lblDelay_ms.TabIndex = 18;
            this.lblDelay_ms.Text = "Verzögerungszeit [ms]";
            this.lblDelay_ms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOff_ms
            // 
            this.txtOff_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOff_ms.Location = new System.Drawing.Point(29, 226);
            this.txtOff_ms.Margin = new System.Windows.Forms.Padding(4);
            this.txtOff_ms.Name = "txtOff_ms";
            this.txtOff_ms.Size = new System.Drawing.Size(137, 26);
            this.txtOff_ms.TabIndex = 17;
            this.txtOff_ms.Text = "0";
            this.txtOff_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOff_ms.TextChanged += new System.EventHandler(this.txtOff_ms_TextChanged);
            // 
            // txtOn_ms
            // 
            this.txtOn_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOn_ms.Location = new System.Drawing.Point(29, 155);
            this.txtOn_ms.Margin = new System.Windows.Forms.Padding(4);
            this.txtOn_ms.Name = "txtOn_ms";
            this.txtOn_ms.Size = new System.Drawing.Size(137, 26);
            this.txtOn_ms.TabIndex = 16;
            this.txtOn_ms.Text = "0";
            this.txtOn_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOn_ms.TextChanged += new System.EventHandler(this.txtOn_ms_TextChanged);
            // 
            // txtDelay_ms
            // 
            this.txtDelay_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelay_ms.Location = new System.Drawing.Point(29, 84);
            this.txtDelay_ms.Margin = new System.Windows.Forms.Padding(4);
            this.txtDelay_ms.Name = "txtDelay_ms";
            this.txtDelay_ms.Size = new System.Drawing.Size(137, 26);
            this.txtDelay_ms.TabIndex = 15;
            this.txtDelay_ms.Text = "0";
            this.txtDelay_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelay_ms.TextChanged += new System.EventHandler(this.txtDelay_ms_TextChanged);
            // 
            // GrpSwMode
            // 
            this.GrpSwMode.Controls.Add(this.lblCounter);
            this.GrpSwMode.Controls.Add(this.txtCounter);
            this.GrpSwMode.Controls.Add(this.cbMode);
            this.GrpSwMode.Location = new System.Drawing.Point(573, 313);
            this.GrpSwMode.Name = "GrpSwMode";
            this.GrpSwMode.Size = new System.Drawing.Size(467, 75);
            this.GrpSwMode.TabIndex = 4;
            this.GrpSwMode.TabStop = false;
            this.GrpSwMode.Text = "Betriebsart";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(241, 40);
            this.lblCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(54, 20);
            this.lblCounter.TabIndex = 22;
            this.lblCounter.Text = "Zähler";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCounter
            // 
            this.txtCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounter.Location = new System.Drawing.Point(304, 35);
            this.txtCounter.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(137, 26);
            this.txtCounter.TabIndex = 21;
            this.txtCounter.Text = "0";
            this.txtCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMode
            // 
            this.cbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Location = new System.Drawing.Point(29, 35);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(184, 28);
            this.cbMode.TabIndex = 1;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // GrpSwTrigger1
            // 
            this.GrpSwTrigger1.Controls.Add(this.lblTriggerChannel);
            this.GrpSwTrigger1.Controls.Add(this.lblTriggerEnable);
            this.GrpSwTrigger1.Controls.Add(this.txtTriggerChannel);
            this.GrpSwTrigger1.Controls.Add(this.ledTriggerEnable);
            this.GrpSwTrigger1.Location = new System.Drawing.Point(573, 108);
            this.GrpSwTrigger1.Name = "GrpSwTrigger1";
            this.GrpSwTrigger1.Size = new System.Drawing.Size(467, 123);
            this.GrpSwTrigger1.TabIndex = 3;
            this.GrpSwTrigger1.TabStop = false;
            this.GrpSwTrigger1.Text = "Triggerung";
            // 
            // lblTriggerChannel
            // 
            this.lblTriggerChannel.BackColor = System.Drawing.Color.Transparent;
            this.lblTriggerChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriggerChannel.Location = new System.Drawing.Point(31, 32);
            this.lblTriggerChannel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriggerChannel.Name = "lblTriggerChannel";
            this.lblTriggerChannel.Size = new System.Drawing.Size(132, 20);
            this.lblTriggerChannel.TabIndex = 22;
            this.lblTriggerChannel.Text = "Triggerkanal";
            this.lblTriggerChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTriggerEnable
            // 
            this.lblTriggerEnable.AutoSize = true;
            this.lblTriggerEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriggerEnable.Location = new System.Drawing.Point(336, 67);
            this.lblTriggerEnable.Name = "lblTriggerEnable";
            this.lblTriggerEnable.Size = new System.Drawing.Size(72, 20);
            this.lblTriggerEnable.TabIndex = 3;
            this.lblTriggerEnable.Text = "Freigabe";
            this.lblTriggerEnable.Click += new System.EventHandler(this.lblTriggerEnable_Click);
            // 
            // txtTriggerChannel
            // 
            this.txtTriggerChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriggerChannel.Location = new System.Drawing.Point(29, 63);
            this.txtTriggerChannel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTriggerChannel.Name = "txtTriggerChannel";
            this.txtTriggerChannel.Size = new System.Drawing.Size(137, 26);
            this.txtTriggerChannel.TabIndex = 21;
            this.txtTriggerChannel.Text = "0";
            this.txtTriggerChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GrpSwSync1
            // 
            this.GrpSwSync1.Controls.Add(this.OptSwAsynchron1);
            this.GrpSwSync1.Controls.Add(this.OptSwSynchron1);
            this.GrpSwSync1.Location = new System.Drawing.Point(19, 414);
            this.GrpSwSync1.Name = "GrpSwSync1";
            this.GrpSwSync1.Size = new System.Drawing.Size(315, 76);
            this.GrpSwSync1.TabIndex = 0;
            this.GrpSwSync1.TabStop = false;
            this.GrpSwSync1.Text = "Sychrone Betriebsart";
            // 
            // OptSwAsynchron1
            // 
            this.OptSwAsynchron1.AutoSize = true;
            this.OptSwAsynchron1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptSwAsynchron1.Location = new System.Drawing.Point(156, 36);
            this.OptSwAsynchron1.Name = "OptSwAsynchron1";
            this.OptSwAsynchron1.Size = new System.Drawing.Size(107, 24);
            this.OptSwAsynchron1.TabIndex = 1;
            this.OptSwAsynchron1.Text = "asynchron";
            this.OptSwAsynchron1.UseVisualStyleBackColor = true;
            // 
            // OptSwSynchron1
            // 
            this.OptSwSynchron1.AutoSize = true;
            this.OptSwSynchron1.Checked = true;
            this.OptSwSynchron1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptSwSynchron1.Location = new System.Drawing.Point(19, 36);
            this.OptSwSynchron1.Name = "OptSwSynchron1";
            this.OptSwSynchron1.Size = new System.Drawing.Size(98, 24);
            this.OptSwSynchron1.TabIndex = 0;
            this.OptSwSynchron1.TabStop = true;
            this.OptSwSynchron1.Text = "synchron";
            this.OptSwSynchron1.UseVisualStyleBackColor = true;
            // 
            // GrpSwImmediate1
            // 
            this.GrpSwImmediate1.Controls.Add(this.OpSwImmediateOff1);
            this.GrpSwImmediate1.Controls.Add(this.OpSwImmediateOn1);
            this.GrpSwImmediate1.Location = new System.Drawing.Point(19, 210);
            this.GrpSwImmediate1.Name = "GrpSwImmediate1";
            this.GrpSwImmediate1.Size = new System.Drawing.Size(315, 76);
            this.GrpSwImmediate1.TabIndex = 17;
            this.GrpSwImmediate1.TabStop = false;
            this.GrpSwImmediate1.Text = "Startverhalten";
            // 
            // OpSwImmediateOff1
            // 
            this.OpSwImmediateOff1.AutoSize = true;
            this.OpSwImmediateOff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpSwImmediateOff1.Location = new System.Drawing.Point(156, 46);
            this.OpSwImmediateOff1.Name = "OpSwImmediateOff1";
            this.OpSwImmediateOff1.Size = new System.Drawing.Size(135, 24);
            this.OpSwImmediateOff1.TabIndex = 3;
            this.OpSwImmediateOff1.Text = "mit ON-Flanke";
            this.OpSwImmediateOff1.UseVisualStyleBackColor = true;
            // 
            // OpSwImmediateOn1
            // 
            this.OpSwImmediateOn1.AutoSize = true;
            this.OpSwImmediateOn1.Checked = true;
            this.OpSwImmediateOn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpSwImmediateOn1.Location = new System.Drawing.Point(19, 46);
            this.OpSwImmediateOn1.Name = "OpSwImmediateOn1";
            this.OpSwImmediateOn1.Size = new System.Drawing.Size(113, 24);
            this.OpSwImmediateOn1.TabIndex = 2;
            this.OpSwImmediateOn1.TabStop = true;
            this.OpSwImmediateOn1.Text = "unmittelbar";
            this.OpSwImmediateOn1.UseVisualStyleBackColor = true;
            // 
            // GrpSwNegation1
            // 
            this.GrpSwNegation1.Controls.Add(this.lblInvertingMode);
            this.GrpSwNegation1.Controls.Add(this.ledInvertingMode);
            this.GrpSwNegation1.Location = new System.Drawing.Point(19, 312);
            this.GrpSwNegation1.Name = "GrpSwNegation1";
            this.GrpSwNegation1.Size = new System.Drawing.Size(315, 76);
            this.GrpSwNegation1.TabIndex = 18;
            this.GrpSwNegation1.TabStop = false;
            this.GrpSwNegation1.Text = "Invertierung";
            // 
            // lblInvertingMode
            // 
            this.lblInvertingMode.AutoSize = true;
            this.lblInvertingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvertingMode.Location = new System.Drawing.Point(66, 43);
            this.lblInvertingMode.Name = "lblInvertingMode";
            this.lblInvertingMode.Size = new System.Drawing.Size(93, 20);
            this.lblInvertingMode.TabIndex = 1;
            this.lblInvertingMode.Text = "Invertierung";
            this.lblInvertingMode.Click += new System.EventHandler(this.lblInvertingMode_Click);
            // 
            // btnOkay
            // 
            this.btnOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.Location = new System.Drawing.Point(777, 426);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(157, 62);
            this.btnOkay.TabIndex = 19;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(573, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 62);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpEnable
            // 
            this.grpEnable.Controls.Add(this.lblEnable);
            this.grpEnable.Controls.Add(this.ledEnable);
            this.grpEnable.Location = new System.Drawing.Point(19, 108);
            this.grpEnable.Name = "grpEnable";
            this.grpEnable.Size = new System.Drawing.Size(315, 76);
            this.grpEnable.TabIndex = 19;
            this.grpEnable.TabStop = false;
            this.grpEnable.Text = "Freigabe";
            // 
            // lblEnable
            // 
            this.lblEnable.AutoSize = true;
            this.lblEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnable.Location = new System.Drawing.Point(66, 43);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(72, 20);
            this.lblEnable.TabIndex = 1;
            this.lblEnable.Text = "Freigabe";
            this.lblEnable.Click += new System.EventHandler(this.lblEnable_Click);
            // 
            // ledEnable
            // 
            this.ledEnable.Location = new System.Drawing.Point(19, 38);
            this.ledEnable.Name = "ledEnable";
            this.ledEnable.On = true;
            this.ledEnable.Size = new System.Drawing.Size(23, 23);
            this.ledEnable.TabIndex = 0;
            this.ledEnable.Text = "Invertierung";
            this.ledEnable.Click += new System.EventHandler(this.ledEnable_Click);
            // 
            // ledInvertingMode
            // 
            this.ledInvertingMode.Location = new System.Drawing.Point(19, 38);
            this.ledInvertingMode.Name = "ledInvertingMode";
            this.ledInvertingMode.On = true;
            this.ledInvertingMode.Size = new System.Drawing.Size(23, 23);
            this.ledInvertingMode.TabIndex = 0;
            this.ledInvertingMode.Text = "Invertierung";
            this.ledInvertingMode.Click += new System.EventHandler(this.ledInvertingMode_Click);
            // 
            // ledTriggerEnable
            // 
            this.ledTriggerEnable.Location = new System.Drawing.Point(293, 62);
            this.ledTriggerEnable.Name = "ledTriggerEnable";
            this.ledTriggerEnable.On = true;
            this.ledTriggerEnable.Size = new System.Drawing.Size(23, 23);
            this.ledTriggerEnable.TabIndex = 2;
            this.ledTriggerEnable.Text = "Invertierung";
            this.ledTriggerEnable.Click += new System.EventHandler(this.ledTriggerEnable_Click);
            // 
            // grpSignalName
            // 
            this.grpSignalName.Controls.Add(this.txtSignalName);
            this.grpSignalName.Location = new System.Drawing.Point(19, 12);
            this.grpSignalName.Name = "grpSignalName";
            this.grpSignalName.Size = new System.Drawing.Size(1021, 76);
            this.grpSignalName.TabIndex = 20;
            this.grpSignalName.TabStop = false;
            this.grpSignalName.Text = "Signalname";
            // 
            // txtSignalName
            // 
            this.txtSignalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignalName.Location = new System.Drawing.Point(19, 35);
            this.txtSignalName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignalName.Name = "txtSignalName";
            this.txtSignalName.Size = new System.Drawing.Size(976, 26);
            this.txtSignalName.TabIndex = 22;
            this.txtSignalName.Text = "0";
            this.txtSignalName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSignalName.TextChanged += new System.EventHandler(this.txtSignalName_TextChanged);
            // 
            // RelayControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1060, 500);
            this.Controls.Add(this.grpSignalName);
            this.Controls.Add(this.grpEnable);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.GrpSwMode);
            this.Controls.Add(this.GrpSwNegation1);
            this.Controls.Add(this.GrpSwTrigger1);
            this.Controls.Add(this.GrpSwImmediate1);
            this.Controls.Add(this.GrpSwSync1);
            this.Controls.Add(this.grpRelayControlTiming);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RelayControlSettings";
            this.Text = "RelayControlSettings";
            this.grpRelayControlTiming.ResumeLayout(false);
            this.grpRelayControlTiming.PerformLayout();
            this.GrpSwMode.ResumeLayout(false);
            this.GrpSwMode.PerformLayout();
            this.GrpSwTrigger1.ResumeLayout(false);
            this.GrpSwTrigger1.PerformLayout();
            this.GrpSwSync1.ResumeLayout(false);
            this.GrpSwSync1.PerformLayout();
            this.GrpSwImmediate1.ResumeLayout(false);
            this.GrpSwImmediate1.PerformLayout();
            this.GrpSwNegation1.ResumeLayout(false);
            this.GrpSwNegation1.PerformLayout();
            this.grpEnable.ResumeLayout(false);
            this.grpEnable.PerformLayout();
            this.grpSignalName.ResumeLayout(false);
            this.grpSignalName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRelayControlTiming;
        private System.Windows.Forms.Label lblOff_ms;
        private System.Windows.Forms.Label lblOn_ms;
        private System.Windows.Forms.Label lblDelay_ms;
        private System.Windows.Forms.TextBox txtOff_ms;
        private System.Windows.Forms.TextBox txtOn_ms;
        private System.Windows.Forms.TextBox txtDelay_ms;
        private System.Windows.Forms.GroupBox GrpSwMode;
        private System.Windows.Forms.GroupBox GrpSwTrigger1;
        private System.Windows.Forms.GroupBox GrpSwSync1;
        private System.Windows.Forms.RadioButton OptSwAsynchron1;
        private System.Windows.Forms.RadioButton OptSwSynchron1;
        private System.Windows.Forms.GroupBox GrpSwImmediate1;
        private System.Windows.Forms.RadioButton OpSwImmediateOff1;
        private System.Windows.Forms.RadioButton OpSwImmediateOn1;
        private System.Windows.Forms.GroupBox GrpSwNegation1;
        private Bulb.LedBulb ledInvertingMode;
        private System.Windows.Forms.Label lblInvertingMode;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpEnable;
        private System.Windows.Forms.Label lblEnable;
        private Bulb.LedBulb ledEnable;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.Label lblTriggerChannel;
        private System.Windows.Forms.Label lblTriggerEnable;
        private System.Windows.Forms.TextBox txtTriggerChannel;
        private Bulb.LedBulb ledTriggerEnable;
        private System.Windows.Forms.GroupBox grpSignalName;
        private System.Windows.Forms.TextBox txtSignalName;
    }
}