namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("BoundingBox", Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class BoundingBoxType {
        
        private string lowerCornerField;
        
        private string upperCornerField;
        
        private string crsField;
        
        private string dimensionsField;
        
        /// <remarks/>
        public string LowerCorner {
            get {
                return this.lowerCornerField;
            }
            set {
                this.lowerCornerField = value;
            }
        }
        
        /// <remarks/>
        public string UpperCorner {
            get {
                return this.upperCornerField;
            }
            set {
                this.upperCornerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string crs {
            get {
                return this.crsField;
            }
            set {
                this.crsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
            }
        }
    }
}
