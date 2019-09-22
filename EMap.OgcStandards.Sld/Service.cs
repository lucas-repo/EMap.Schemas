namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public enum Service {
        
        /// <remarks/>
        WFS,
        
        /// <remarks/>
        WCS,
    }
}
