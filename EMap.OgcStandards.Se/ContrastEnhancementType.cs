namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("ContrastEnhancement", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class ContrastEnhancementType {
        
        private object itemField;
        
        private double gammaValueField;
        
        private bool gammaValueFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Histogram", typeof(HistogramType))]
        [System.Xml.Serialization.XmlElementAttribute("Normalize", typeof(NormalizeType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public double GammaValue {
            get {
                return this.gammaValueField;
            }
            set {
                this.gammaValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GammaValueSpecified {
            get {
                return this.gammaValueFieldSpecified;
            }
            set {
                this.gammaValueFieldSpecified = value;
            }
        }
    }
}
