namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Interpolate", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class InterpolateType : FunctionType1 {
        
        private ParameterValueType lookupValueField;
        
        private InterpolationPointType[] interpolationPointField;
        
        private ModeType modeField;
        
        private bool modeFieldSpecified;
        
        private MethodType methodField;
        
        private bool methodFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ParameterValueType LookupValue {
            get {
                return this.lookupValueField;
            }
            set {
                this.lookupValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterpolationPoint", Order=1)]
        public InterpolationPointType[] InterpolationPoint {
            get {
                return this.interpolationPointField;
            }
            set {
                this.interpolationPointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ModeType mode {
            get {
                return this.modeField;
            }
            set {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modeSpecified {
            get {
                return this.modeFieldSpecified;
            }
            set {
                this.modeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MethodType method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool methodSpecified {
            get {
                return this.methodFieldSpecified;
            }
            set {
                this.methodFieldSpecified = value;
            }
        }
    }
}
