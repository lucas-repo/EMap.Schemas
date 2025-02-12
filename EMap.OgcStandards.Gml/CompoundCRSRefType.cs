﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("compoundCRSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CompoundCRSRefType {
        
        private CompoundCRSType compoundCRSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public CompoundCRSType CompoundCRS {
            get {
                return this.compoundCRSField;
            }
            set {
                this.compoundCRSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
}
