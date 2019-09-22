namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("RectifiedGrid", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class RectifiedGridType : GridType {
        
        private PointPropertyType originField;
        
        private VectorType[] offsetVectorField;
        
        /// <remarks/>
        public PointPropertyType origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offsetVector")]
        public VectorType[] offsetVector {
            get {
                return this.offsetVectorField;
            }
            set {
                this.offsetVectorField = value;
            }
        }
    }
}
