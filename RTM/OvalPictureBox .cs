﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTM
{
  class OvalPictureBox : PictureBox
  {
    public OvalPictureBox()
    {
      BackColor = Color.DarkGray;
    }
    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      using (var gp = new GraphicsPath())
      {
        gp.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
        Region = new Region(gp);
      }
    }
  }
}
