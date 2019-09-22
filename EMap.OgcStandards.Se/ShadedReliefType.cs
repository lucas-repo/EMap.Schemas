namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("ShadedRelief", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class ShadedReliefType {
        
        private bool brightnessOnlyField;
        
        private bool brightnessOnlyFieldSpecified;
        
        private double reliefFactorField;
        
        private bool reliefFactorFieldSpecified;
        
        /// <remarks/>
        public bool BrightnessOnly {
            get {
                return this.brightnessOnlyField;
            }
            set {
                this.brightnessOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrightnessOnlySpecified {
            get {
                return this.brightnessOnlyFieldSpecified;
            }
            set {
                this.brightnessOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double ReliefFactor {
            get {
                return this.reliefFactorField;
            }
            set {
                this.reliefFactorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReliefFactorSpecified {
            get {
                return this.reliefFactorFieldSpecified;
            }
            set {
                this.reliefFactorFieldSpecified = value;
            }
        }
    }
}
