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
    [KnownType(typeof(SE_USUARIO))]
    [KnownType(typeof(SI_PARAMETRO))]
    [KnownType(typeof(MA_OCUPACION))]
    [KnownType(typeof(RE_PERSONA))]
    public partial class RE_REGISTROUNICO: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public long reun_iRegistroUnicoId
        {
            get { return _reun_iRegistroUnicoId; }
            set
            {
                if (_reun_iRegistroUnicoId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'reun_iRegistroUnicoId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _reun_iRegistroUnicoId = value;
                    OnPropertyChanged("reun_iRegistroUnicoId");
                }
            }
        }
        private long _reun_iRegistroUnicoId;
    
        [DataMember]
        public long reun_iPersonaId
        {
            get { return _reun_iPersonaId; }
            set
            {
                if (_reun_iPersonaId != value)
                {
                    ChangeTracker.RecordOriginalValue("reun_iPersonaId", _reun_iPersonaId);
                    if (!IsDeserializing)
                    {
                        if (RE_PERSONA != null && RE_PERSONA.pers_iPersonaId != value)
                        {
                            RE_PERSONA = null;
                        }
                    }
                    _reun_iPersonaId = value;
                    OnPropertyChanged("reun_iPersonaId");
                }
            }
        }
        private long _reun_iPersonaId;
    
        [DataMember]
        public string reun_vEmergenciaNombre
        {
            get { return _reun_vEmergenciaNombre; }
            set
            {
                if (_reun_vEmergenciaNombre != value)
                {
                    _reun_vEmergenciaNombre = value;
                    OnPropertyChanged("reun_vEmergenciaNombre");
                }
            }
        }
        private string _reun_vEmergenciaNombre;
    
        [DataMember]
        public Nullable<short> reun_sEmergenciaRelacionId
        {
            get { return _reun_sEmergenciaRelacionId; }
            set
            {
                if (_reun_sEmergenciaRelacionId != value)
                {
                    ChangeTracker.RecordOriginalValue("reun_sEmergenciaRelacionId", _reun_sEmergenciaRelacionId);
                    if (!IsDeserializing)
                    {
                        if (SI_PARAMETRO != null && SI_PARAMETRO.para_sParametroId != value)
                        {
                            SI_PARAMETRO = null;
                        }
                    }
                    _reun_sEmergenciaRelacionId = value;
                    OnPropertyChanged("reun_sEmergenciaRelacionId");
                }
            }
        }
        private Nullable<short> _reun_sEmergenciaRelacionId;
    
        [DataMember]
        public string reun_vEmergenciaDireccionLocal
        {
            get { return _reun_vEmergenciaDireccionLocal; }
            set
            {
                if (_reun_vEmergenciaDireccionLocal != value)
                {
                    _reun_vEmergenciaDireccionLocal = value;
                    OnPropertyChanged("reun_vEmergenciaDireccionLocal");
                }
            }
        }
        private string _reun_vEmergenciaDireccionLocal;
    
        [DataMember]
        public string reun_vEmergenciaCodigoPostal
        {
            get { return _reun_vEmergenciaCodigoPostal; }
            set
            {
                if (_reun_vEmergenciaCodigoPostal != value)
                {
                    _reun_vEmergenciaCodigoPostal = value;
                    OnPropertyChanged("reun_vEmergenciaCodigoPostal");
                }
            }
        }
        private string _reun_vEmergenciaCodigoPostal;
    
        [DataMember]
        public string reun_vEmergenciaTelefono
        {
            get { return _reun_vEmergenciaTelefono; }
            set
            {
                if (_reun_vEmergenciaTelefono != value)
                {
                    _reun_vEmergenciaTelefono = value;
                    OnPropertyChanged("reun_vEmergenciaTelefono");
                }
            }
        }
        private string _reun_vEmergenciaTelefono;
    
        [DataMember]
        public string reun_vEmergenciaDireccionPeru
        {
            get { return _reun_vEmergenciaDireccionPeru; }
            set
            {
                if (_reun_vEmergenciaDireccionPeru != value)
                {
                    _reun_vEmergenciaDireccionPeru = value;
                    OnPropertyChanged("reun_vEmergenciaDireccionPeru");
                }
            }
        }
        private string _reun_vEmergenciaDireccionPeru;
    
        [DataMember]
        public string reun_vEmergenciaCorreoElectronico
        {
            get { return _reun_vEmergenciaCorreoElectronico; }
            set
            {
                if (_reun_vEmergenciaCorreoElectronico != value)
                {
                    _reun_vEmergenciaCorreoElectronico = value;
                    OnPropertyChanged("reun_vEmergenciaCorreoElectronico");
                }
            }
        }
        private string _reun_vEmergenciaCorreoElectronico;
    
        [DataMember]
        public string reun_cViveExteriorDesde
        {
            get { return _reun_cViveExteriorDesde; }
            set
            {
                if (_reun_cViveExteriorDesde != value)
                {
                    _reun_cViveExteriorDesde = value;
                    OnPropertyChanged("reun_cViveExteriorDesde");
                }
            }
        }
        private string _reun_cViveExteriorDesde;
    
        [DataMember]
        public Nullable<bool> reun_bPiensaRetornarAlPeru
        {
            get { return _reun_bPiensaRetornarAlPeru; }
            set
            {
                if (_reun_bPiensaRetornarAlPeru != value)
                {
                    _reun_bPiensaRetornarAlPeru = value;
                    OnPropertyChanged("reun_bPiensaRetornarAlPeru");
                }
            }
        }
        private Nullable<bool> _reun_bPiensaRetornarAlPeru;
    
        [DataMember]
        public string reun_cCuandoRetornaAlPeru
        {
            get { return _reun_cCuandoRetornaAlPeru; }
            set
            {
                if (_reun_cCuandoRetornaAlPeru != value)
                {
                    _reun_cCuandoRetornaAlPeru = value;
                    OnPropertyChanged("reun_cCuandoRetornaAlPeru");
                }
            }
        }
        private string _reun_cCuandoRetornaAlPeru;
    
        [DataMember]
        public Nullable<bool> reun_bAfiliadoSeguroSocial
        {
            get { return _reun_bAfiliadoSeguroSocial; }
            set
            {
                if (_reun_bAfiliadoSeguroSocial != value)
                {
                    _reun_bAfiliadoSeguroSocial = value;
                    OnPropertyChanged("reun_bAfiliadoSeguroSocial");
                }
            }
        }
        private Nullable<bool> _reun_bAfiliadoSeguroSocial;
    
        [DataMember]
        public Nullable<bool> reun_bAfiliadoAFP
        {
            get { return _reun_bAfiliadoAFP; }
            set
            {
                if (_reun_bAfiliadoAFP != value)
                {
                    _reun_bAfiliadoAFP = value;
                    OnPropertyChanged("reun_bAfiliadoAFP");
                }
            }
        }
        private Nullable<bool> _reun_bAfiliadoAFP;
    
        [DataMember]
        public Nullable<bool> reun_bAportaSeguroSocial
        {
            get { return _reun_bAportaSeguroSocial; }
            set
            {
                if (_reun_bAportaSeguroSocial != value)
                {
                    _reun_bAportaSeguroSocial = value;
                    OnPropertyChanged("reun_bAportaSeguroSocial");
                }
            }
        }
        private Nullable<bool> _reun_bAportaSeguroSocial;
    
        [DataMember]
        public Nullable<bool> reun_bBeneficiadoExterior
        {
            get { return _reun_bBeneficiadoExterior; }
            set
            {
                if (_reun_bBeneficiadoExterior != value)
                {
                    _reun_bBeneficiadoExterior = value;
                    OnPropertyChanged("reun_bBeneficiadoExterior");
                }
            }
        }
        private Nullable<bool> _reun_bBeneficiadoExterior;
    
        [DataMember]
        public Nullable<short> reun_sOcupacionPeru
        {
            get { return _reun_sOcupacionPeru; }
            set
            {
                if (_reun_sOcupacionPeru != value)
                {
                    ChangeTracker.RecordOriginalValue("reun_sOcupacionPeru", _reun_sOcupacionPeru);
                    if (!IsDeserializing)
                    {
                        if (MA_OCUPACION1 != null && MA_OCUPACION1.ocup_sOcupacionId != value)
                        {
                            MA_OCUPACION1 = null;
                        }
                    }
                    _reun_sOcupacionPeru = value;
                    OnPropertyChanged("reun_sOcupacionPeru");
                }
            }
        }
        private Nullable<short> _reun_sOcupacionPeru;
    
        [DataMember]
        public Nullable<short> reun_sOcupacionExtranjero
        {
            get { return _reun_sOcupacionExtranjero; }
            set
            {
                if (_reun_sOcupacionExtranjero != value)
                {
                    ChangeTracker.RecordOriginalValue("reun_sOcupacionExtranjero", _reun_sOcupacionExtranjero);
                    if (!IsDeserializing)
                    {
                        if (MA_OCUPACION != null && MA_OCUPACION.ocup_sOcupacionId != value)
                        {
                            MA_OCUPACION = null;
                        }
                    }
                    _reun_sOcupacionExtranjero = value;
                    OnPropertyChanged("reun_sOcupacionExtranjero");
                }
            }
        }
        private Nullable<short> _reun_sOcupacionExtranjero;
    
        [DataMember]
        public string reun_vNombreConvenio
        {
            get { return _reun_vNombreConvenio; }
            set
            {
                if (_reun_vNombreConvenio != value)
                {
                    _reun_vNombreConvenio = value;
                    OnPropertyChanged("reun_vNombreConvenio");
                }
            }
        }
        private string _reun_vNombreConvenio;
    
        [DataMember]
        public string reun_cEstado
        {
            get { return _reun_cEstado; }
            set
            {
                if (_reun_cEstado != value)
                {
                    _reun_cEstado = value;
                    OnPropertyChanged("reun_cEstado");
                }
            }
        }
        private string _reun_cEstado;
    
        [DataMember]
        public short reun_sUsuarioCreacion
        {
            get { return _reun_sUsuarioCreacion; }
            set
            {
                if (_reun_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("reun_sUsuarioCreacion", _reun_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _reun_sUsuarioCreacion = value;
                    OnPropertyChanged("reun_sUsuarioCreacion");
                }
            }
        }
        private short _reun_sUsuarioCreacion;
    
        [DataMember]
        public string reun_vIPCreacion
        {
            get { return _reun_vIPCreacion; }
            set
            {
                if (_reun_vIPCreacion != value)
                {
                    _reun_vIPCreacion = value;
                    OnPropertyChanged("reun_vIPCreacion");
                }
            }
        }
        private string _reun_vIPCreacion;
    
        [DataMember]
        public System.DateTime reun_dFechaCreacion
        {
            get { return _reun_dFechaCreacion; }
            set
            {
                if (_reun_dFechaCreacion != value)
                {
                    _reun_dFechaCreacion = value;
                    OnPropertyChanged("reun_dFechaCreacion");
                }
            }
        }
        private System.DateTime _reun_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> reun_sUsuarioModificacion
        {
            get { return _reun_sUsuarioModificacion; }
            set
            {
                if (_reun_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("reun_sUsuarioModificacion", _reun_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _reun_sUsuarioModificacion = value;
                    OnPropertyChanged("reun_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _reun_sUsuarioModificacion;
    
        [DataMember]
        public string reun_vIPModificacion
        {
            get { return _reun_vIPModificacion; }
            set
            {
                if (_reun_vIPModificacion != value)
                {
                    _reun_vIPModificacion = value;
                    OnPropertyChanged("reun_vIPModificacion");
                }
            }
        }
        private string _reun_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> reun_dFechaModificacion
        {
            get { return _reun_dFechaModificacion; }
            set
            {
                if (_reun_dFechaModificacion != value)
                {
                    _reun_dFechaModificacion = value;
                    OnPropertyChanged("reun_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _reun_dFechaModificacion;

        #endregion
        #region Navigation Properties
    
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
        public SI_PARAMETRO SI_PARAMETRO
        {
            get { return _sI_PARAMETRO; }
            set
            {
                if (!ReferenceEquals(_sI_PARAMETRO, value))
                {
                    var previousValue = _sI_PARAMETRO;
                    _sI_PARAMETRO = value;
                    FixupSI_PARAMETRO(previousValue);
                    OnNavigationPropertyChanged("SI_PARAMETRO");
                }
            }
        }
        private SI_PARAMETRO _sI_PARAMETRO;
    
        [DataMember]
        public MA_OCUPACION MA_OCUPACION
        {
            get { return _mA_OCUPACION; }
            set
            {
                if (!ReferenceEquals(_mA_OCUPACION, value))
                {
                    var previousValue = _mA_OCUPACION;
                    _mA_OCUPACION = value;
                    FixupMA_OCUPACION(previousValue);
                    OnNavigationPropertyChanged("MA_OCUPACION");
                }
            }
        }
        private MA_OCUPACION _mA_OCUPACION;
    
        [DataMember]
        public MA_OCUPACION MA_OCUPACION1
        {
            get { return _mA_OCUPACION1; }
            set
            {
                if (!ReferenceEquals(_mA_OCUPACION1, value))
                {
                    var previousValue = _mA_OCUPACION1;
                    _mA_OCUPACION1 = value;
                    FixupMA_OCUPACION1(previousValue);
                    OnNavigationPropertyChanged("MA_OCUPACION1");
                }
            }
        }
        private MA_OCUPACION _mA_OCUPACION1;
    
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
            SE_USUARIO = null;
            SE_USUARIO1 = null;
            SI_PARAMETRO = null;
            MA_OCUPACION = null;
            MA_OCUPACION1 = null;
            RE_PERSONA = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_REGISTROUNICO.Contains(this))
            {
                previousValue.RE_REGISTROUNICO.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.RE_REGISTROUNICO.Contains(this))
                {
                    SE_USUARIO.RE_REGISTROUNICO.Add(this);
                }
    
                reun_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.RE_REGISTROUNICO1.Contains(this))
            {
                previousValue.RE_REGISTROUNICO1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.RE_REGISTROUNICO1.Contains(this))
                {
                    SE_USUARIO1.RE_REGISTROUNICO1.Add(this);
                }
    
                reun_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                reun_sUsuarioModificacion = null;
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
    
        private void FixupSI_PARAMETRO(SI_PARAMETRO previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_REGISTROUNICO.Contains(this))
            {
                previousValue.RE_REGISTROUNICO.Remove(this);
            }
    
            if (SI_PARAMETRO != null)
            {
                if (!SI_PARAMETRO.RE_REGISTROUNICO.Contains(this))
                {
                    SI_PARAMETRO.RE_REGISTROUNICO.Add(this);
                }
    
                reun_sEmergenciaRelacionId = SI_PARAMETRO.para_sParametroId;
            }
            else if (!skipKeys)
            {
                reun_sEmergenciaRelacionId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SI_PARAMETRO")
                    && (ChangeTracker.OriginalValues["SI_PARAMETRO"] == SI_PARAMETRO))
                {
                    ChangeTracker.OriginalValues.Remove("SI_PARAMETRO");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SI_PARAMETRO", previousValue);
                }
                if (SI_PARAMETRO != null && !SI_PARAMETRO.ChangeTracker.ChangeTrackingEnabled)
                {
                    SI_PARAMETRO.StartTracking();
                }
            }
        }
    
        private void FixupMA_OCUPACION(MA_OCUPACION previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_REGISTROUNICO.Contains(this))
            {
                previousValue.RE_REGISTROUNICO.Remove(this);
            }
    
            if (MA_OCUPACION != null)
            {
                if (!MA_OCUPACION.RE_REGISTROUNICO.Contains(this))
                {
                    MA_OCUPACION.RE_REGISTROUNICO.Add(this);
                }
    
                reun_sOcupacionExtranjero = MA_OCUPACION.ocup_sOcupacionId;
            }
            else if (!skipKeys)
            {
                reun_sOcupacionExtranjero = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("MA_OCUPACION")
                    && (ChangeTracker.OriginalValues["MA_OCUPACION"] == MA_OCUPACION))
                {
                    ChangeTracker.OriginalValues.Remove("MA_OCUPACION");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("MA_OCUPACION", previousValue);
                }
                if (MA_OCUPACION != null && !MA_OCUPACION.ChangeTracker.ChangeTrackingEnabled)
                {
                    MA_OCUPACION.StartTracking();
                }
            }
        }
    
        private void FixupMA_OCUPACION1(MA_OCUPACION previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_REGISTROUNICO1.Contains(this))
            {
                previousValue.RE_REGISTROUNICO1.Remove(this);
            }
    
            if (MA_OCUPACION1 != null)
            {
                if (!MA_OCUPACION1.RE_REGISTROUNICO1.Contains(this))
                {
                    MA_OCUPACION1.RE_REGISTROUNICO1.Add(this);
                }
    
                reun_sOcupacionPeru = MA_OCUPACION1.ocup_sOcupacionId;
            }
            else if (!skipKeys)
            {
                reun_sOcupacionPeru = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("MA_OCUPACION1")
                    && (ChangeTracker.OriginalValues["MA_OCUPACION1"] == MA_OCUPACION1))
                {
                    ChangeTracker.OriginalValues.Remove("MA_OCUPACION1");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("MA_OCUPACION1", previousValue);
                }
                if (MA_OCUPACION1 != null && !MA_OCUPACION1.ChangeTracker.ChangeTrackingEnabled)
                {
                    MA_OCUPACION1.StartTracking();
                }
            }
        }
    
        private void FixupRE_PERSONA(RE_PERSONA previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_REGISTROUNICO.Contains(this))
            {
                previousValue.RE_REGISTROUNICO.Remove(this);
            }
    
            if (RE_PERSONA != null)
            {
                if (!RE_PERSONA.RE_REGISTROUNICO.Contains(this))
                {
                    RE_PERSONA.RE_REGISTROUNICO.Add(this);
                }
    
                reun_iPersonaId = RE_PERSONA.pers_iPersonaId;
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
