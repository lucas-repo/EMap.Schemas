namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("vector", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class VectorType {
        
        private string srsNameField;
        
        private string srsDimensionField;
        
        private string textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string srsName {
            get {
                return this.srsNameField;
            }
            set {
                this.srsNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string srsDimension {
            get {
                return this.srsDimensionField;
            }
            set {
                this.srsDimensionField = value;
            }
        }
        
        /// <remarks/>
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
                    string[] array = Text.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
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
