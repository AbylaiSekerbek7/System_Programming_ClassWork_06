
namespace SampleSemaphore
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
      this.lbWait = new System.Windows.Forms.ListBox();
      this.lbActive = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtLog = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCntAll = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtCntActive = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnCreate = new System.Windows.Forms.Button();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbWait
      // 
      this.lbWait.FormattingEnabled = true;
      this.lbWait.HorizontalScrollbar = true;
      this.lbWait.Location = new System.Drawing.Point(12, 38);
      this.lbWait.Name = "lbWait";
      this.lbWait.Size = new System.Drawing.Size(184, 212);
      this.lbWait.TabIndex = 0;
      // 
      // lbActive
      // 
      this.lbActive.FormattingEnabled = true;
      this.lbActive.HorizontalScrollbar = true;
      this.lbActive.Location = new System.Drawing.Point(202, 38);
      this.lbActive.Name = "lbActive";
      this.lbActive.Size = new System.Drawing.Size(184, 212);
      this.lbActive.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(108, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Ожидающие потоки";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(199, 20);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(95, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Активные потоки";
      // 
      // txtLog
      // 
      this.txtLog.Location = new System.Drawing.Point(12, 283);
      this.txtLog.Multiline = true;
      this.txtLog.Name = "txtLog";
      this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtLog.Size = new System.Drawing.Size(374, 188);
      this.txtLog.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 267);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(83, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Вывод, журнал";
      // 
      // txtCntAll
      // 
      this.txtCntAll.Location = new System.Drawing.Point(408, 38);
      this.txtCntAll.Name = "txtCntAll";
      this.txtCntAll.Size = new System.Drawing.Size(100, 20);
      this.txtCntAll.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(405, 20);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(111, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Кол-во всех потоков";
      // 
      // txtCntActive
      // 
      this.txtCntActive.Location = new System.Drawing.Point(408, 84);
      this.txtCntActive.Name = "txtCntActive";
      this.txtCntActive.Size = new System.Drawing.Size(100, 20);
      this.txtCntActive.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(405, 68);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(136, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Кол-во активных потоков";
      // 
      // btnCreate
      // 
      this.btnCreate.Location = new System.Drawing.Point(408, 143);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(144, 23);
      this.btnCreate.TabIndex = 10;
      this.btnCreate.Text = "Создать потоки";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(408, 172);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(144, 23);
      this.btnStart.TabIndex = 11;
      this.btnStart.Text = "Запустить потоки";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(441, 227);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 12;
      this.btnClose.Text = "Закрыть";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(615, 483);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.btnCreate);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtCntActive);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtCntAll);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtLog);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lbActive);
      this.Controls.Add(this.lbWait);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbWait;
    private System.Windows.Forms.ListBox lbActive;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtLog;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCntAll;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtCntActive;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnClose;
  }
}

