using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    public class NavbarUC : FlowLayoutPanel
    {
        private List<NavbarItemUC> items = new List<NavbarItemUC>();

        public EventHandler OnClickEvent;

        public NavbarItemUC activeItem = null;

        public NavbarUC()
        {
            this.BackColor = Color.White;
            this.Dock = DockStyle.Top;
            this.Height = 70;
        }

        public void AddItem(string title, bool active = false)
        {
            NavbarItemUC item = new NavbarItemUC(title, active);
            this.Controls.Add(item);
            items.Add(item);

            if (active)
            {
                activeItem = item;
            }

            item.OnClickEvent += (o, e) =>
            {
                OnClickEvent.Invoke(o, e);
            };

            if (active)
            {
                item.OnClick(null, null);
            }
        }

        public List<NavbarItemUC> GetItems()
        {
            return items;
        }

        public NavbarItemUC GetItem(string name)
        {
            return items.Find(x => x.title == name);
        }

        public void SetActiveItem(NavbarItemUC item)
        {
            activeItem = item;
        }

        public void Select(string item)
        {
            GetItem(item).OnClick(null, null);
        }
    }
}
