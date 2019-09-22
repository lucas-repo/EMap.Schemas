namespace EMap.OgcStandards.Sld
{
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class CoverageConstraint {
        
        private string coverageNameField;
        
        private CoverageExtent coverageExtentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/se")]
        public string CoverageName {
            get {
                return this.coverageNameField;
            }
            set {
                this.coverageNameField = value;
            }
        }
        
        /// <remarks/>
        public CoverageExtent CoverageExtent {
            get {
                return this.coverageExtentField;
            }
            set {
                this.coverageExtentField = value;
            }
        }
    }
}
