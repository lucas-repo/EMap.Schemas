namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public partial class SortPropertyType {
        
        private PropertyNameType propertyNameField;
        
        private SortOrderType sortOrderField;
        
        private bool sortOrderFieldSpecified;
        
        /// <remarks/>
        public PropertyNameType PropertyName {
            get {
                return this.propertyNameField;
            }
            set {
                this.propertyNameField = value;
            }
        }
        
        /// <remarks/>
        public SortOrderType SortOrder {
            get {
                return this.sortOrderField;
            }
            set {
                this.sortOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortOrderSpecified {
            get {
                return this.sortOrderFieldSpecified;
            }
            set {
                this.sortOrderFieldSpecified = value;
            }
        }
    }
}
