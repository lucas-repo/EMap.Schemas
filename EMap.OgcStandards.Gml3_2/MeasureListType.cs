using System;

namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("valueList", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MeasureListType {
        
        private string uomField;
        
        private string textField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
        public double[] Value
        {
            get
            {
                double[] value = null;
                if (!string.IsNullOrEmpty(Text))
                {
                    string[] array = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    value = new double[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        var item = array[i];
                        if (!double.TryParse(item, out double val))
                        {
                            value = null;
                            break;
                        }
                        else
                        {
                            value[i] = val;
                        }
                    }
                }
                return value;
            }
        }
    }
}
