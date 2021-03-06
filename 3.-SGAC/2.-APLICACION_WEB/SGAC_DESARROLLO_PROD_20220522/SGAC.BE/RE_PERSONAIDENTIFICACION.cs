//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace SGAC.BE
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(MA_DOCUMENTO_IDENTIDAD))]
    [KnownType(typeof(SE_USUARIO))]
    [KnownType(typeof(RE_PERSONA))]
    public partial class RE_PERSONAIDENTIFICACION: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public long peid_iPersonaIdentificacionId
        {
            get { return _peid_iPersonaIdentificacionId; }
            set
            {
                if (_peid_iPersonaIdentificacionId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'peid_iPersonaIdentificacionId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _peid_iPersonaIdentificacionId = value;
                    OnPropertyChanged("peid_iPersonaIdentificacionId");
                }
            }
        }
        private long _peid_iPersonaIdentificacionId;
    
        [DataMember]
        public long peid_iPersonaId
        {
            get { return _peid_iPersonaId; }
            set
            {
                if (_peid_iPersonaId != value)
                {
                    ChangeTracker.RecordOriginalValue("peid_iPersonaId", _peid_iPersonaId);
                    if (!IsDeserializing)
                    {
                        if (RE_PERSONA != null && RE_PERSONA.pers_iPersonaId != value)
                        {
                            RE_PERSONA = null;
                        }
                    }
                    _peid_iPersonaId = value;
                    OnPropertyChanged("peid_iPersonaId");
                }
            }
        }
        private long _peid_iPersonaId;
    
        [DataMember]
        public short peid_sDocumentoTipoId
        {
            get { return _peid_sDocumentoTipoId; }
            set
            {
                if (_peid_sDocumentoTipoId != value)
                {
                    ChangeTracker.RecordOriginalValue("peid_sDocumentoTipoId", _peid_sDocumentoTipoId);
                    if (!IsDeserializing)
                    {
                        if (MA_DOCUMENTO_IDENTIDAD != null && MA_DOCUMENTO_IDENTIDAD.doid_sTipoDocumentoIdentidadId != value)
                        {
                            MA_DOCUMENTO_IDENTIDAD = null;
                        }
                    }
                    _peid_sDocumentoTipoId = value;
                    OnPropertyChanged("peid_sDocumentoTipoId");
                }
            }
        }
        private short _peid_sDocumentoTipoId;
    
        [DataMember]
        public string peid_vDocumentoNumero
        {
            get { return _peid_vDocumentoNumero; }
            set
            {
                if (_peid_vDocumentoNumero != value)
                {
                    _peid_vDocumentoNumero = value;
                    OnPropertyChanged("peid_vDocumentoNumero");
                }
            }
        }
        private string _peid_vDocumentoNumero;
    
        [DataMember]
        public Nullable<System.DateTime> peid_dFecVcto
        {
            get { return _peid_dFecVcto; }
            set
            {
                if (_peid_dFecVcto != value)
                {
                    _peid_dFecVcto = value;
                    OnPropertyChanged("peid_dFecVcto");
                }
            }
        }
        private Nullable<System.DateTime> _peid_dFecVcto;
    
        [DataMember]
        public Nullable<System.DateTime> peid_dFecExpedicion
        {
            get { return _peid_dFecExpedicion; }
            set
            {
                if (_peid_dFecExpedicion != value)
                {
                    _peid_dFecExpedicion = value;
                    OnPropertyChanged("peid_dFecExpedicion");
                }
            }
        }
        private Nullable<System.DateTime> _peid_dFecExpedicion;
    
        [DataMember]
        public string peid_vLugarExpedicion
        {
            get { return _peid_vLugarExpedicion; }
            set
            {
                if (_peid_vLugarExpedicion != value)
                {
                    _peid_vLugarExpedicion = value;
                    OnPropertyChanged("peid_vLugarExpedicion");
                }
            }
        }
        private string _peid_vLugarExpedicion;
    
        [DataMember]
        public Nullable<System.DateTime> peid_dFecRenovacion
        {
            get { return _peid_dFecRenovacion; }
            set
            {
                if (_peid_dFecRenovacion != value)
                {
                    _peid_dFecRenovacion = value;
                    OnPropertyChanged("peid_dFecRenovacion");
                }
            }
        }
        private Nullable<System.DateTime> _peid_dFecRenovacion;
    
        [DataMember]
        public string peid_vLugarRenovacion
        {
            get { return _peid_vLugarRenovacion; }
            set
            {
                if (_peid_vLugarRenovacion != value)
                {
                    _peid_vLugarRenovacion = value;
                    OnPropertyChanged("peid_vLugarRenovacion");
                }
            }
        }
        private string _peid_vLugarRenovacion;
    
        [DataMember]
        public bool peid_bActivoEnRune
        {
            get { return _peid_bActivoEnRune; }
            set
            {
                if (_peid_bActivoEnRune != value)
                {
                    _peid_bActivoEnRune = value;
                    OnPropertyChanged("peid_bActivoEnRune");
                }
            }
        }
        private bool _peid_bActivoEnRune;
    
        [DataMember]
        public string peid_cEstado
        {
            get { return _peid_cEstado; }
            set
            {
                if (_peid_cEstado != value)
                {
                    _peid_cEstado = value;
                    OnPropertyChanged("peid_cEstado");
                }
            }
        }
        private string _peid_cEstado;
    
        [DataMember]
        public short peid_sUsuarioCreacion
        {
            get { return _peid_sUsuarioCreacion; }
            set
            {
                if (_peid_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("peid_sUsuarioCreacion", _peid_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _peid_sUsuarioCreacion = value;
                    OnPropertyChanged("peid_sUsuarioCreacion");
                }
            }
        }
        private short _peid_sUsuarioCreacion;
    
        [DataMember]
        public string peid_vIPCreacion
        {
            get { return _peid_vIPCreacion; }
            set
            {
                if (_peid_vIPCreacion != value)
                {
                    _peid_vIPCreacion = value;
                    OnPropertyChanged("peid_vIPCreacion");
                }
            }
        }
        private string _peid_vIPCreacion;
    
        [DataMember]
        public System.DateTime peid_dFechaCreacion
        {
            get { return _peid_dFechaCreacion; }
            set
            {
                if (_peid_dFechaCreacion != value)
                {
                    _peid_dFechaCreacion = value;
                    OnPropertyChanged("peid_dFechaCreacion");
                }
            }
        }
        private System.DateTime _peid_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> peid_sUsuarioModificacion
        {
            get { return _peid_sUsuarioModificacion; }
            set
            {
                if (_peid_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("peid_sUsuarioModificacion", _peid_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _peid_sUsuarioModificacion = value;
                    OnPropertyChanged("peid_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _peid_sUsuarioModificacion;
    
        [DataMember]
        public string peid_vIPModificacion
        {
            get { return _peid_vIPModificacion; }
            set
            {
                if (_peid_vIPModificacion != value)
                {
                    _peid_vIPModificacion = value;
                    OnPropertyChanged("peid_vIPModificacion");
                }
            }
        }
        private string _peid_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> peid_dFechaModificacion
        {
            get { return _peid_dFechaModificacion; }
            set
            {
                if (_peid_dFechaModificacion != value)
                {
                    _peid_dFechaModificacion = value;
                    OnPropertyChanged("peid_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _peid_dFechaModificacion;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public MA_DOCUMENTO_IDENTIDAD MA_DOCUMENTO_IDENTIDAD
        {
            get { return _mA_DOCUMENTO_IDENTIDAD; }
            set
            {
                if (!ReferenceEquals(_mA_DOCUMENTO_IDENTIDAD, value))
                {
                    var previousValue = _mA_DOCUMENTO_IDENTIDAD;
                    _mA_DOCUMENTO_IDENTIDAD = value;
                    FixupMA_DOCUMENTO_IDENTIDAD(previousValue);
                    OnNavigationPropertyChanged("MA_DOCUMENTO_IDENTIDAD");
                }
            }
        }
        private MA_DOCUMENTO_IDENTIDAD _mA_DOCUMENTO_IDENTIDAD;
    
        [DataMember]
        public SE_USUARIO SE_USUARIO
        {
            get { return _sE_USUARIO; }
            set
            {
                if (!ReferenceEquals(_sE_USUARIO, value))
                {
                    var previousValue = _sE_USUARIO;
                    _sE_USUARIO = value;
                    FixupSE_USUARIO(previousValue);
                    OnNavigationPropertyChanged("SE_USUARIO");
                }
            }
        }
        private SE_USUARIO _sE_USUARIO;
    
        [DataMember]
        public SE_USUARIO SE_USUARIO1
        {
            get { return _sE_USUARIO1; }
            set
            {
                if (!ReferenceEquals(_sE_USUARIO1, value))
                {
                    var previousValue = _sE_USUARIO1;
                    _sE_USUARIO1 = value;
                    FixupSE_USUARIO1(previousValue);
                    OnNavigationPropertyChanged("SE_USUARIO1");
                }
            }
        }
        private SE_USUARIO _sE_USUARIO1;
    
        [DataMember]
        public RE_PERSONA RE_PERSONA
        {
            get { return _rE_PERSONA; }
            set
            {
                if (!ReferenceEquals(_rE_PERSONA, value))
                {
                    var previousValue = _rE_PERSONA;
                    _rE_PERSONA = value;
                    FixupRE_PERSONA(previousValue);
                    OnNavigationPropertyChanged("RE_PERSONA");
                }
            }
        }
        private RE_PERSONA _rE_PERSONA;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
    
    
    
    
    		private Int16 _sOficinaConsularId;
    	[DataMember]
        public Int16 OficinaConsularId
        {
            get
            {
    			return _sOficinaConsularId;
    		}
    		set
    		{
    			_sOficinaConsularId = value;
    		}
    	}
    	private Int16 _sDiferenciaHoraria;
    	[DataMember]
        public Int16 DiferenciaHoraria
        {
            get
            {
    			return _sDiferenciaHoraria;
    		}
    		set
    		{
    			_sDiferenciaHoraria = value;
    		}
    	}
    	private Int16 _sHorarioVerano;
    	[DataMember]
        public Int16 HorarioVerano
        {
            get
            {
    			return _sHorarioVerano;
    		}
    		set
    		{
    			_sHorarioVerano = value;
    		}
    	}
    
    
    
    
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            MA_DOCUMENTO_IDENTIDAD = null;
            SE_USUARIO = null;
            SE_USUARIO1 = null;
            RE_PERSONA = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupMA_DOCUMENTO_IDENTIDAD(MA_DOCUMENTO_IDENTIDAD previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_PERSONAIDENTIFICACION.Contains(this))
            {
                previousValue.RE_PERSONAIDENTIFICACION.Remove(this);
            }
    
            if (MA_DOCUMENTO_IDENTIDAD != null)
            {
                if (!MA_DOCUMENTO_IDENTIDAD.RE_PERSONAIDENTIFICACION.Contains(this))
                {
                    MA_DOCUMENTO_IDENTIDAD.RE_PERSONAIDENTIFICACION.Add(this);
                }
    
                peid_sDocumentoTipoId = MA_DOCUMENTO_IDENTIDAD.doid_sTipoDocumentoIdentidadId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("MA_DOCUMENTO_IDENTIDAD")
                    && (ChangeTracker.OriginalValues["MA_DOCUMENTO_IDENTIDAD"] == MA_DOCUMENTO_IDENTIDAD))
                {
                    ChangeTracker.OriginalValues.Remove("MA_DOCUMENTO_IDENTIDAD");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("MA_DOCUMENTO_IDENTIDAD", previousValue);
                }
                if (MA_DOCUMENTO_IDENTIDAD != null && !MA_DOCUMENTO_IDENTIDAD.ChangeTracker.ChangeTrackingEnabled)
                {
                    MA_DOCUMENTO_IDENTIDAD.StartTracking();
                }
            }
        }
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_PERSONAIDENTIFICACION.Contains(this))
            {
                previousValue.RE_PERSONAIDENTIFICACION.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.RE_PERSONAIDENTIFICACION.Contains(this))
                {
                    SE_USUARIO.RE_PERSONAIDENTIFICACION.Add(this);
                }
    
                peid_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SE_USUARIO")
                    && (ChangeTracker.OriginalValues["SE_USUARIO"] == SE_USUARIO))
                {
                    ChangeTracker.OriginalValues.Remove("SE_USUARIO");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SE_USUARIO", previousValue);
                }
                if (SE_USUARIO != null && !SE_USUARIO.ChangeTracker.ChangeTrackingEnabled)
                {
                    SE_USUARIO.StartTracking();
                }
            }
        }
    
        private void FixupSE_USUARIO1(SE_USUARIO previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_PERSONAIDENTIFICACION1.Contains(this))
            {
                previousValue.RE_PERSONAIDENTIFICACION1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.RE_PERSONAIDENTIFICACION1.Contains(this))
                {
                    SE_USUARIO1.RE_PERSONAIDENTIFICACION1.Add(this);
                }
    
                peid_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                peid_sUsuarioModificacion = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SE_USUARIO1")
                    && (ChangeTracker.OriginalValues["SE_USUARIO1"] == SE_USUARIO1))
                {
                    ChangeTracker.OriginalValues.Remove("SE_USUARIO1");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SE_USUARIO1", previousValue);
                }
                if (SE_USUARIO1 != null && !SE_USUARIO1.ChangeTracker.ChangeTrackingEnabled)
                {
                    SE_USUARIO1.StartTracking();
                }
            }
        }
    
        private void FixupRE_PERSONA(RE_PERSONA previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_PERSONAIDENTIFICACION.Contains(this))
            {
                previousValue.RE_PERSONAIDENTIFICACION.Remove(this);
            }
    
            if (RE_PERSONA != null)
            {
                if (!RE_PERSONA.RE_PERSONAIDENTIFICACION.Contains(this))
                {
                    RE_PERSONA.RE_PERSONAIDENTIFICACION.Add(this);
                }
    
                peid_iPersonaId = RE_PERSONA.pers_iPersonaId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("RE_PERSONA")
                    && (ChangeTracker.OriginalValues["RE_PERSONA"] == RE_PERSONA))
                {
                    ChangeTracker.OriginalValues.Remove("RE_PERSONA");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("RE_PERSONA", previousValue);
                }
                if (RE_PERSONA != null && !RE_PERSONA.ChangeTracker.ChangeTrackingEnabled)
                {
                    RE_PERSONA.StartTracking();
                }
            }
        }

        #endregion
    }
}
