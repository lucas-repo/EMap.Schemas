namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sld")]
    public partial class IntervalType {
        
        private double minField;
        
        private double maxField;
        
        /// <remarks/>
        public double Min {
            get {
                return this.minField;
            }
            set {
                this.minField = value;
            }
        }
        
        /// <remarks/>
        public double Max {
            get {
                return this.maxField;
            }
            set {
                this.maxField = value;
            }
        }
    }
}
