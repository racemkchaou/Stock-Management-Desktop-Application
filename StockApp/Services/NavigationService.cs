using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.Services
{
    public class NavigationService
    {
        private readonly Form _mainForm;
        private readonly Dictionary<Type, Form> _openForms = new Dictionary<Type, Form>();

        public NavigationService(Form mainForm)
        {
            _mainForm = mainForm;
        }

        public void ShowForm<T>() where T : Form, new()
        {
            if (!_openForms.ContainsKey(typeof(T)))
            {
                var form = new T { MdiParent = _mainForm };
                _openForms.Add(typeof(T), form);
                form.FormClosed += (s, e) => _openForms.Remove(typeof(T));
                form.Show();
            }
            else
            {
                _openForms[typeof(T)].BringToFront();
            }
        }
    }
}
