using EMap.OgcStandards.Ogc;

namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecodeType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="FunctionType", Namespace="http://www.opengis.net/se")]
    public abstract partial class FunctionType1 : ExpressionType {
        
        private string fallbackValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fallbackValue {
            get {
                return this.fallbackValueField;
            }
            set {
                this.fallbackValueField = value;
            }
        }
    }
}
