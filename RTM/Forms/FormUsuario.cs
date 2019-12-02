using ControllerRTM;
using ControllerRTM.Controller;
using ControllerRTM.Interfaces;
using RTM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTM
{
  public partial class FormUsuario : Form, IController
  {
    private readonly UsuarioController controller = new UsuarioController(CurrentUserInfo.Username);
    private int customerId;
    public FormUsuario()
    {
      InitializeComponent();
      toolStrip1_ItemClicked(null, new ToolStripItemClickedEventArgs(toolStripButtonUndo));
    }

    public bool SaveEntity()
    {
      bool result =true;
      try
      {
        result = controller.SaveEntity();

        if (result)
        { 
          EnableDisableControls(toolStripButtonUndo);
          ScatterEntityValues();
        }
      }
      catch (Exception)
      {
        result = false;
      }

      return result;
    }

    public bool DeleteEntity(params object[] ids)
    {
      return controller.DeleteEntity(ids);
    }

    public bool SearchEntity(params object[] ids)
    {
      return controller.SearchEntity(ids);
    }

    public void AddNewEntity()
    {
      controller.AddNewEntity();
    }

    public void ScatterEntityValues()
    {
      controller.ScatterEntityValues();
      customerId = controller.Id;
      textBoxFirstName.Text = controller.FirstName;
      textBoxLastName.Text = controller.LastName;
      dateTimePickerBirthDate.Value = controller.BirthDate;
      textBoxUsername.Text = controller.Username;
      textBoxPassword.Text = controller.Password;
      textBoxAddress.Text = controller.Address;
      metroComboBoxCity.SelectedItem = controller.City;
      textBoxZipCode.Text = controller.ZipCode;
      textBoxPosition.Text = controller.Position;
      textBoxPhone.Text = controller.Phone;
      richTextBoxNotes.Text = controller.Notes;

      if (controller.Avatar != null && controller.Avatar.Length > 0)
      {
        ovalPictureBox2.Image = byteToImage(controller.Avatar);
      }
      else
      {
        ovalPictureBox2.Image = null;
      }
    }

    public void GattherEntityValues()
    {
      controller.Id = customerId;
      controller.FirstName = textBoxFirstName.Text;
      controller.LastName = textBoxLastName.Text;
      controller.BirthDate = dateTimePickerBirthDate.Value;
      controller.Username = textBoxUsername.Text;
      controller.Password = textBoxPassword.Text;
      controller.Address = textBoxAddress.Text;
      controller.City = metroComboBoxCity.SelectedItem != null ? metroComboBoxCity.SelectedItem.ToString() : string.Empty;
      controller.ZipCode = textBoxZipCode.Text;
      controller.Position = textBoxPosition.Text;
      controller.Phone = textBoxPhone.Text;
      controller.Notes = richTextBoxNotes.Text;

      if (ovalPictureBox2.Image != null)
        controller.Avatar = imageToByte(ovalPictureBox2.Image);

      controller.GattherEntityValues();
    }

    private byte[] imageToByte(Image img)
    {
      ImageConverter converter = new ImageConverter();
      //bug aqui.
      return (byte[])converter.ConvertTo(img, typeof(byte[]));
    }

    private Bitmap byteToImage(byte[] image)
    {
      MemoryStream mStream = new MemoryStream();
      byte[] pData = image;
      mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
      Bitmap bm = new Bitmap(mStream, false);
      mStream.Dispose();
      return bm;
    }

    public DataTable LoadDataTable(string criteria)
    {
      throw new NotImplementedException();
    }

    private void toolStripButtonSearch_Click(object sender, EventArgs e)
    {
      FormGenericSearch formSearch = new FormGenericSearch(controller);
      formSearch.TopLevel = true;
      formSearch.FormClosed += (oSender, oE) =>
      {
        if (formSearch.DialogResult == System.Windows.Forms.DialogResult.OK && SearchEntity(formSearch.Id))
        {
          ScatterEntityValues();
        }
      };

      formSearch.Show();
    }

    private void toolStripButtonAdd_Click(object sender, EventArgs e)
    {
      string msg = string.Empty;
      GattherEntityValues();

      msg = SaveEntity() ? "Completado!" : "Algo anda mal!";

      MessageBox.Show(msg);
    }

    private void ovalPictureBox2_Click(object sender, EventArgs e)
    {
      openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
      openFileDialog1.FileOk += openFileDialog1_FileOk;
      openFileDialog1.ShowDialog();
    }

    void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      if (openFileDialog1.CheckFileExists)
      {
        var path = openFileDialog1.FileName;
        //var img = File.ReadAllBytes(path);

        ovalPictureBox2.Load(path);
      }
    }

    private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      ToolStripItem clickedItem = e.ClickedItem;
      switch (clickedItem.Name)
      {
        case "toolStripButtonNew":
          toolStripButtonAdd.Enabled = true;
          toolStripButtonUndo.Enabled = true;
          toolStripButtonNew.Enabled = false;
          toolStripButtonEdit.Enabled = false;
          toolStripButtonDelete.Enabled = false;
          toolStripButtonPrint.Enabled = false;
          toolStripButtonSearch.Enabled = false;
          break;

        case "toolStripButtonAdd":
          toolStripButtonNew.Enabled = true;
          toolStripButtonEdit.Enabled = true;
          toolStripButtonDelete.Enabled = true;
          toolStripButtonPrint.Enabled = true;
          toolStripButtonSearch.Enabled = true;
          toolStripButtonUndo.Enabled = false;
          break;

        case "toolStripButtonEdit":
          toolStripButtonAdd.Enabled = true;
          toolStripButtonUndo.Enabled = true;
          toolStripButtonEdit.Enabled = false;
          toolStripButtonNew.Enabled = false;
          toolStripButtonDelete.Enabled = false;
          toolStripButtonPrint.Enabled = false;
          toolStripButtonSearch.Enabled = false;
          break;

        case "toolStripButtonSearch":
          toolStripButtonNew.Enabled = true;
          toolStripButtonSearch.Enabled = true;
          toolStripButtonDelete.Enabled = true;
          toolStripButtonPrint.Enabled = true;
          toolStripButtonEdit.Enabled = true;
          toolStripButtonAdd.Enabled = false;
          toolStripButtonUndo.Enabled = false;
          clickedItem = toolStripButtonUndo;
          break;

        case "toolStripButtonDelete":
          clickedItem = toolStripButtonUndo;
          break;

        case "toolStripButtonPrint":
          clickedItem = toolStripButtonUndo;
          break;

        default:
          toolStripButtonNew.Enabled = true;
          toolStripButtonSearch.Enabled = true;
          toolStripButtonUndo.Enabled = false;
          toolStripButtonAdd.Enabled = false;
          toolStripButtonEdit.Enabled = false;
          toolStripButtonDelete.Enabled = false;
          toolStripButtonPrint.Enabled = false;
          break;
      }

      EnableDisableControls(clickedItem);
    }

    private void EnableDisableControls(ToolStripItem toolBarState)
    {
      bool habilitar = toolBarState.Name != toolStripButtonUndo.Name;
      ovalPictureBox2.Enabled = habilitar;
      textBoxFirstName.Enabled = habilitar;
      textBoxLastName.Enabled = habilitar;
      dateTimePickerBirthDate.Enabled = habilitar;
      textBoxUsername.Enabled = habilitar;
      textBoxPassword.Enabled = habilitar;
      textBoxAddress.Enabled = habilitar;
      metroComboBoxCity.Enabled = habilitar;
      textBoxZipCode.Enabled = habilitar;
      textBoxPosition.Enabled = habilitar;
      textBoxPhone.Enabled = habilitar;
      richTextBoxNotes.Enabled = habilitar;
    }

    private void clearControls()
    {
      customerId = 0;
      ovalPictureBox2.Image = null;
      textBoxFirstName.Clear();
      textBoxLastName.Clear();
      dateTimePickerBirthDate.Value = DateTime.Now;
      textBoxUsername.Clear();
      textBoxPassword.Clear();
      textBoxAddress.Clear();
      metroComboBoxCity.SelectedItem = null;
      textBoxZipCode.Clear();
      textBoxPosition.Clear();
      textBoxPhone.Clear();
      richTextBoxNotes.Clear();
    }


    private void toolStripButtonUndo_Click(object sender, EventArgs e)
    {
      ScatterEntityValues();
    }

    private void toolStripButtonNew_Click(object sender, EventArgs e)
    {
      AddNewEntity();
      clearControls();
    }

    private void toolStripButtonPrint_Click(object sender, EventArgs e)
    {
      FormReportViewer formReport = new FormReportViewer(@"../../Reports/EmployeeReport.rpt", "Customer", controller.LoadDataUser());
      formReport.StartPosition = FormStartPosition.CenterScreen;
      formReport.WindowState = FormWindowState.Maximized;
      formReport.Show();
      formReport.RefreshReport();
    }

    private void toolStripButtonEdit_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButtonDelete_Click(object sender, EventArgs e)
    {

    }
  }
}
