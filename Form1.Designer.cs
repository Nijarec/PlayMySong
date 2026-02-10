using System.Drawing;
using System.Windows.Forms;

namespace PlayMySong
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelReproduccion = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.btnPlayList = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblSongName = new System.Windows.Forms.Label();
            this.pictureCover = new System.Windows.Forms.PictureBox();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.lstPlaylist = new System.Windows.Forms.ListBox();
            this.panelMedios = new System.Windows.Forms.Panel();
            this.trackProgress1 = new CustomSlider();
            this.trackVolume = new CustomSlider();
            this.panelReproduccion.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).BeginInit();
            this.panelMedios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReproduccion
            // 
            this.panelReproduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelReproduccion.Controls.Add(this.trackProgress1);
            this.panelReproduccion.Controls.Add(this.flowLayoutPanel1);
            this.panelReproduccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReproduccion.Location = new System.Drawing.Point(0, 350);
            this.panelReproduccion.Name = "panelReproduccion";
            this.panelReproduccion.Size = new System.Drawing.Size(800, 100);
            this.panelReproduccion.TabIndex = 0;
            this.panelReproduccion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblVolume);
            this.flowLayoutPanel1.Controls.Add(this.trackVolume);
            this.flowLayoutPanel1.Controls.Add(this.btnAtras);
            this.flowLayoutPanel1.Controls.Add(this.btnPlay);
            this.flowLayoutPanel1.Controls.Add(this.btnAdelante);
            this.flowLayoutPanel1.Controls.Add(this.lblCurrentTime);
            this.flowLayoutPanel1.Controls.Add(this.lblTotalTime);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 81);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVolume.Location = new System.Drawing.Point(0, 10);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(39, 29);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "🔊";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtras.Location = new System.Drawing.Point(144, 13);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAtras.Size = new System.Drawing.Size(65, 65);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "⏮";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlay.Location = new System.Drawing.Point(215, 13);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlay.Size = new System.Drawing.Size(65, 65);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdelante.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdelante.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdelante.Location = new System.Drawing.Point(286, 13);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdelante.Size = new System.Drawing.Size(65, 65);
            this.btnAdelante.TabIndex = 1;
            this.btnAdelante.Text = "⏭";
            this.btnAdelante.UseVisualStyleBackColor = false;
            this.btnAdelante.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentTime.Location = new System.Drawing.Point(354, 10);
            this.lblCurrentTime.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(44, 17);
            this.lblCurrentTime.TabIndex = 7;
            this.lblCurrentTime.Text = "00:00";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalTime.Location = new System.Drawing.Point(404, 10);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(44, 17);
            this.lblTotalTime.TabIndex = 8;
            this.lblTotalTime.Text = "00:00";
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelOpciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelOpciones.BackgroundImage")));
            this.PanelOpciones.Controls.Add(this.btnPlayList);
            this.PanelOpciones.Controls.Add(this.btnOpen);
            this.PanelOpciones.Controls.Add(this.lblSongName);
            this.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelOpciones.Location = new System.Drawing.Point(0, 0);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(800, 33);
            this.PanelOpciones.TabIndex = 2;
            this.PanelOpciones.Resize += new System.EventHandler(this.panelTop_Resize);
            // 
            // btnPlayList
            // 
            this.btnPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnPlayList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlayList.FlatAppearance.BorderSize = 0;
            this.btnPlayList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPlayList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayList.Font = new System.Drawing.Font("Arial", 18F);
            this.btnPlayList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlayList.Location = new System.Drawing.Point(95, 0);
            this.btnPlayList.Name = "btnPlayList";
            this.btnPlayList.Size = new System.Drawing.Size(75, 33);
            this.btnPlayList.TabIndex = 10;
            this.btnPlayList.Text = "📃";
            this.btnPlayList.UseVisualStyleBackColor = false;
            this.btnPlayList.Visible = false;
            this.btnPlayList.Click += new System.EventHandler(this.BtnPlaylist_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(95, 33);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSongName.Location = new System.Drawing.Point(-10, 0);
            this.lblSongName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(16, 17);
            this.lblSongName.TabIndex = 9;
            this.lblSongName.Text = "_";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureCover
            // 
            this.pictureCover.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureCover.Location = new System.Drawing.Point(0, 0);
            this.pictureCover.Name = "pictureCover";
            this.pictureCover.Size = new System.Drawing.Size(800, 317);
            this.pictureCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCover.TabIndex = 1;
            this.pictureCover.TabStop = false;
            this.pictureCover.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 500;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.BackColor = System.Drawing.Color.Black;
            this.lstPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlaylist.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlaylist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstPlaylist.FormattingEnabled = true;
            this.lstPlaylist.ItemHeight = 18;
            this.lstPlaylist.Location = new System.Drawing.Point(0, 0);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(800, 317);
            this.lstPlaylist.TabIndex = 3;
            this.lstPlaylist.Visible = false;
            this.lstPlaylist.DoubleClick += new System.EventHandler(this.LstPlaylist_DoubleClick);
            // 
            // panelMedios
            // 
            this.panelMedios.Controls.Add(this.lstPlaylist);
            this.panelMedios.Controls.Add(this.pictureCover);
            this.panelMedios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMedios.Location = new System.Drawing.Point(0, 33);
            this.panelMedios.Name = "panelMedios";
            this.panelMedios.Size = new System.Drawing.Size(800, 317);
            this.panelMedios.TabIndex = 4;
            // 
            // trackProgress1
            // 
            this.trackProgress1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackProgress1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackProgress1.Location = new System.Drawing.Point(0, 0);
            this.trackProgress1.Maximum = 100;
            this.trackProgress1.Minimum = 0;
            this.trackProgress1.Name = "trackProgress1";
            this.trackProgress1.ProgressColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackProgress1.Size = new System.Drawing.Size(800, 21);
            this.trackProgress1.TabIndex = 7;
            this.trackProgress1.Text = "customSlider1";
            this.trackProgress1.ThumbColor = System.Drawing.Color.White;
            this.trackProgress1.ThumbRadius = 7;
            this.trackProgress1.TrackColor = System.Drawing.Color.DimGray;
            this.trackProgress1.TrackHeight = 6;
            this.trackProgress1.Value = 0;
            this.trackProgress1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackProgress1_MouseUp);
            // 
            // trackVolume
            // 
            this.trackVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.trackVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackVolume.Location = new System.Drawing.Point(42, 13);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Minimum = 0;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.ProgressColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackVolume.Size = new System.Drawing.Size(96, 23);
            this.trackVolume.TabIndex = 8;
            this.trackVolume.Text = "customSlider1";
            this.trackVolume.ThumbColor = System.Drawing.Color.White;
            this.trackVolume.ThumbRadius = 7;
            this.trackVolume.TrackColor = System.Drawing.Color.DimGray;
            this.trackVolume.TrackHeight = 6;
            this.trackVolume.Value = 50;
            this.trackVolume.ValueChanged += new System.EventHandler(this.trackVolume_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMedios);
            this.Controls.Add(this.panelReproduccion);
            this.Controls.Add(this.PanelOpciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelReproduccion.ResumeLayout(false);
            this.panelReproduccion.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.PanelOpciones.ResumeLayout(false);
            this.PanelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).EndInit();
            this.panelMedios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReproduccion;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel PanelOpciones;
        private Button btnOpen;
        private Label lblVolume;
        private PictureBox pictureCover;
        private Label lblTotalTime;
        private Label lblCurrentTime;
        private Timer timerProgress;
        private Label lblSongName;
        private ListBox lstPlaylist;
        private Button btnPlayList;
        private Panel panelMedios;
        private CustomSlider trackProgress1;
        private CustomSlider trackVolume;
    }
}

