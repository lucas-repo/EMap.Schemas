namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("ColorReplacement", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class ColorReplacementType {
        
        private RecodeType recodeField;
        
        /// <remarks/>
        public RecodeType Recode {
            get {
                return this.recodeField;
            }
            set {
                this.recodeField = value;
            }
        }
    }
}
