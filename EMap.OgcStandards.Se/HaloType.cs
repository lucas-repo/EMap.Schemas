namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Halo", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class HaloType {
        
        private ParameterValueType radiusField;
        
        private FillType fillField;
        
        /// <remarks/>
        public ParameterValueType Radius {
            get {
                return this.radiusField;
            }
            set {
                this.radiusField = value;
            }
        }
        
        /// <remarks/>
        public FillType Fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
    }
}
