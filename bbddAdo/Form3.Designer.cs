namespace bbddAdo
{
    partial class FormRellenarCancelarPedido
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
            this.lblIdentificadorPedido = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.dvgCostumerOrders = new System.Windows.Forms.DataGridView();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnRellenarPedido = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCostumerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdentificadorPedido
            // 
            this.lblIdentificadorPedido.AutoSize = true;
            this.lblIdentificadorPedido.Location = new System.Drawing.Point(50, 53);
            this.lblIdentificadorPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificadorPedido.Name = "lblIdentificadorPedido";
            this.lblIdentificadorPedido.Size = new System.Drawing.Size(162, 18);
            this.lblIdentificadorPedido.TabIndex = 0;
            this.lblIdentificadorPedido.Text = "Identificador del pedido:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(220, 50);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(217, 24);
            this.txtIdPedido.TabIndex = 1;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.Location = new System.Drawing.Point(459, 46);
            this.btnBuscarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(112, 32);
            this.btnBuscarPedido.TabIndex = 2;
            this.btnBuscarPedido.Text = "Buscar pedido";
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(50, 110);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(334, 18);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Si esta rellenando un pedido, especifique la fecha:";
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(401, 110);
            this.dtpFillDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(141, 24);
            this.dtpFillDate.TabIndex = 4;
            // 
            // dvgCostumerOrders
            // 
            this.dvgCostumerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCostumerOrders.Location = new System.Drawing.Point(54, 192);
            this.dvgCostumerOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dvgCostumerOrders.Name = "dvgCostumerOrders";
            this.dvgCostumerOrders.ReadOnly = true;
            this.dvgCostumerOrders.RowHeadersVisible = false;
            this.dvgCostumerOrders.Size = new System.Drawing.Size(672, 166);
            this.dvgCostumerOrders.TabIndex = 5;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(54, 404);
            this.btnCancelarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(112, 52);
            this.btnCancelarPedido.TabIndex = 6;
            this.btnCancelarPedido.Text = "Cancelar pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnRellenarPedido
            // 
            this.btnRellenarPedido.Location = new System.Drawing.Point(174, 404);
            this.btnRellenarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnRellenarPedido.Name = "btnRellenarPedido";
            this.btnRellenarPedido.Size = new System.Drawing.Size(112, 52);
            this.btnRellenarPedido.TabIndex = 7;
            this.btnRellenarPedido.Text = "Rellenar pedido";
            this.btnRellenarPedido.UseVisualStyleBackColor = true;
            this.btnRellenarPedido.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(590, 404);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(134, 52);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // FormRellenarCancelarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 516);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRellenarPedido);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.dvgCostumerOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.lblIdentificadorPedido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRellenarCancelarPedido";
            this.Text = "Rellenar o cancelar un pedido - Miguel Sanchez";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCostumerOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentificadorPedido;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.DataGridView dvgCostumerOrders;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnRellenarPedido;
        private System.Windows.Forms.Button btnFinalizar;
    }
}