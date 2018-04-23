using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
// ...

namespace ChangeDisplayNameForCalculatedField {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 rep = new XtraReport1();
            rep.DesignerLoaded += new DesignerLoadedEventHandler(rep_DesignerLoaded);
            rep.ShowDesignerDialog();
        }

        void rep_DesignerLoaded(object sender, DesignerLoadedEventArgs e) {
            ITypeDescriptorFilterService svc = (ITypeDescriptorFilterService)e.DesignerHost.GetService(typeof(ITypeDescriptorFilterService));
            CustomTypeDescriptorFilterService customSvc = new CustomTypeDescriptorFilterService(svc);
            e.DesignerHost.RemoveService(typeof(ITypeDescriptorFilterService));
            e.DesignerHost.AddService(typeof(ITypeDescriptorFilterService), customSvc);
        }
    }

    class CustomTypeDescriptorFilterService : ITypeDescriptorFilterService {
        ITypeDescriptorFilterService svc;
        public CustomTypeDescriptorFilterService(ITypeDescriptorFilterService svc) {
            this.svc = svc;
        }

        #region ITypeDescriptorFilterService Members
        bool ITypeDescriptorFilterService.FilterAttributes(IComponent component, IDictionary attributes) {
            return svc.FilterAttributes(component, attributes);
        }
        bool ITypeDescriptorFilterService.FilterEvents(IComponent component, IDictionary events) {
            return svc.FilterEvents(component, events);
        }
        bool ITypeDescriptorFilterService.FilterProperties(IComponent component, IDictionary properties) {
            bool result = svc.FilterProperties(component, properties);
            if (component is CalculatedField) {
                Attribute[] attributes = new Attribute[] { BrowsableAttribute.Yes };
                properties["DisplayName"] = TypeDescriptor.CreateProperty(typeof(CalculatedField), (PropertyDescriptor)properties["DisplayName"], attributes);
            }
            return result;
        }
        #endregion
    }
}
