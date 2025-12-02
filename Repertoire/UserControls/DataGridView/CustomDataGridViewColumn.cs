using System;

namespace Theaters.UserControls
{
    public class CustomDataGridViewColumn
    {
        private string name;
        private string header_text;
        private float fill_weight;
        private Delegate onClick;

        public CustomDataGridViewColumn(string name, string headerText, float fillWeight, Delegate onClick = null)
        {
            this.name = name;
            this.header_text = headerText;
            this.fill_weight = fillWeight;
            this.onClick = onClick;
        }

        public string getName() { return name; }
        public string getHeaderText() { return header_text; }
        public float getFillWeight() { return fill_weight; }
        public Delegate getClickEvent() { return onClick; }
    }
}
