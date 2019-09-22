namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/se", IsNullable=false)]
    public enum OverlapBehavior {
        
        /// <remarks/>
        LATEST_ON_TOP,
        
        /// <remarks/>
        EARLIEST_ON_TOP,
        
        /// <remarks/>
        AVERAGE,
        
        /// <remarks/>
        RANDOM,
    }
}
