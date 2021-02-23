using System;
using System.Collections.Generic;
using ProjetoRafael.Controller;
using ProjetoRafael.Model;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafael.View {
    public partial class Usuarios : Form {
        public Usuarios() {
            InitializeComponent();

            listUser.Items.Clear();

            UserController useContr = new UserController();
            List<User> usuAux = useContr.ListarUser();

            if (usuAux.Count > 0) {
                foreach (var ser in usuAux) {
                    ListViewItem lv = new ListViewItem(ser.Id.ToString());
                    lv.SubItems.Add(ser.Nome);
                    lv.SubItems.Add(ser.Senha);
                    lv.SubItems.Add(ser.Perfil);
                    
                    listUser.Items.Add(lv);
                }

            }
        }
    }
}
