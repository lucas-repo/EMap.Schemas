namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("SortBy", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class SortByType {
        
        private SortPropertyType[] sortPropertyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SortProperty")]
        public SortPropertyType[] SortProperty {
            get {
                return this.sortPropertyField;
            }
            set {
                this.sortPropertyField = value;
            }
        }
    }
}
