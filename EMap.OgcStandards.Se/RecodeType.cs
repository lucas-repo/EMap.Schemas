namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Recode", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class RecodeType : FunctionType1 {
        
        private ParameterValueType lookupValueField;
        
        private MapItemType[] mapItemField;
        
        /// <remarks/>
        public ParameterValueType LookupValue {
            get {
                return this.lookupValueField;
            }
            set {
                this.lookupValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MapItem")]
        public MapItemType[] MapItem {
            get {
                return this.mapItemField;
            }
            set {
                this.mapItemField = value;
            }
        }
    }
}
