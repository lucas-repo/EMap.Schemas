namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Array", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ArrayType : AbstractGMLType {
        
        private object[] membersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Object", IsNullable=false)]
        public object[] members {
            get {
                return this.membersField;
            }
            set {
                this.membersField = value;
            }
        }
    }
}
