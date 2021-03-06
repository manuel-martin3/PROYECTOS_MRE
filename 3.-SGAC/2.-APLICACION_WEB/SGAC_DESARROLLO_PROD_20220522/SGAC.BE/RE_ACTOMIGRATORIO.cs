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
    [KnownType(typeof(MA_ESTADO))]
    [KnownType(typeof(RE_ACTUACIONDETALLE))]
    [KnownType(typeof(SE_USUARIO))]
    [KnownType(typeof(SI_PARAMETRO))]
    [KnownType(typeof(RE_ACTOMIGRATORIOFORMATO))]
    [KnownType(typeof(RE_ACTOMIGRATORIOHISTORICO))]
    public partial class RE_ACTOMIGRATORIO: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public long acmi_iActoMigratorioId
        {
            get { return _acmi_iActoMigratorioId; }
            set
            {
                if (_acmi_iActoMigratorioId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'acmi_iActoMigratorioId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _acmi_iActoMigratorioId = value;
                    OnPropertyChanged("acmi_iActoMigratorioId");
                }
            }
        }
        private long _acmi_iActoMigratorioId;
    
        [DataMember]
        public long acmi_iActuacionDetalleId
        {
            get { return _acmi_iActuacionDetalleId; }
            set
            {
                if (_acmi_iActuacionDetalleId != value)
                {
                    ChangeTracker.RecordOriginalValue("acmi_iActuacionDetalleId", _acmi_iActuacionDetalleId);
                    if (!IsDeserializing)
                    {
                        if (RE_ACTUACIONDETALLE != null && RE_ACTUACIONDETALLE.acde_iActuacionDetalleId != value)
                        {
                            RE_ACTUACIONDETALLE = null;
                        }
                    }
                    _acmi_iActuacionDetalleId = value;
                    OnPropertyChanged("acmi_iActuacionDetalleId");
                }
            }
        }
        private long _acmi_iActuacionDetalleId;
    
        [DataMember]
        public int acmi_IFuncionarioId
        {
            get { return _acmi_IFuncionarioId; }
            set
            {
                if (_acmi_IFuncionarioId != value)
                {
                    _acmi_IFuncionarioId = value;
                    OnPropertyChanged("acmi_IFuncionarioId");
                }
            }
        }
        private int _acmi_IFuncionarioId;
    
        [DataMember]
        public short acmi_sTipoDocumentoMigratorioId
        {
            get { return _acmi_sTipoDocumentoMigratorioId; }
            set
            {
                if (_acmi_sTipoDocumentoMigratorioId != value)
                {
                    ChangeTracker.RecordOriginalValue("acmi_sTipoDocumentoMigratorioId", _acmi_sTipoDocumentoMigratorioId);
                    if (!IsDeserializing)
                    {
                        if (MA_DOCUMENTO_IDENTIDAD != null && MA_DOCUMENTO_IDENTIDAD.doid_sTipoDocumentoIdentidadId != value)
                        {
                            MA_DOCUMENTO_IDENTIDAD = null;
                        }
                        if (SI_PARAMETRO2 != null && SI_PARAMETRO2.para_sParametroId != value)
                        {
                            SI_PARAMETRO2 = null;
                        }
                    }
                    _acmi_sTipoDocumentoMigratorioId = value;
                    OnPropertyChanged("acmi_sTipoDocumentoMigratorioId");
                }
            }
        }
        private short _acmi_sTipoDocumentoMigratorioId;
    
        [DataMember]
        public Nullable<short> acmi_sTipoId
        {
            get { return _acmi_sTipoId; }
            set
            {
                if (_acmi_sTipoId != value)
                {
                    ChangeTracker.RecordOriginalValue("acmi_sTipoId", _acmi_sTipoId);
                    if (!IsDeserializing)
                    {
                        if (SI_PARAMETRO != null && SI_PARAMETRO.para_sParametroId != value)
                        {
                            SI_PARAMETRO = null;
                        }
                    }
                    _acmi_sTipoId = value;
                    OnPropertyChanged("acmi_sTipoId");
                }
            }
        }
        private Nullable<short> _acmi_sTipoId;
    
        [DataMember]
        public Nullable<short> acmi_sSubTipoId
        {
            get { return _acmi_sSubTipoId; }
            set
            {
                if (_acmi_sSubTipoId != value)
                {
                    ChangeTracker.RecordOriginalValue("acmi_sSubTipoId", _acmi_sSubTipoId);
                    if (!IsDeserializing)
                    {
                        if (SI_PARAMETRO1 != null && SI_PARAMETRO1.para_sParametroId != value)
                        {
                            SI_PARAMETRO1 = null;
                        }
                    }
                    _acmi_sSubTipoId = value;
                    OnPropertyChanged("acmi_sSubTipoId");
                }
            }
        }
        private Nullable<short> _acmi_sSubTipoId;
    
        [DataMember]
        public string acmi_vNumeroExpediente
        {
            get { return _acmi_vNumeroExpediente; }
            set
            {
                if (_acmi_vNumeroExpediente != value)
                {
                    _acmi_vNumeroExpediente = value;
                    OnPropertyChanged("acmi_vNumeroExpediente");
                }
            }
        }
        private string _acmi_vNumeroExpediente;
    
        [DataMember]
        public string acmi_vNumeroLamina
        {
            get { return _acmi_vNumeroLamina; }
            set
            {
                if (_acmi_vNumeroLamina != value)
                {
                    _acmi_vNumeroLamina = value;
                    OnPropertyChanged("acmi_vNumeroLamina");
                }
            }
        }
        private string _acmi_vNumeroLamina;
    
        [DataMember]
        public System.DateTime acmi_dFechaExpedicion
        {
            get { return _acmi_dFechaExpedicion; }
            set
            {
                if (_acmi_dFechaExpedicion != value)
                {
                    _acmi_dFechaExpedicion = value;
                    OnPropertyChanged("acmi_dFechaExpedicion");
                }
            }
        }
        private System.DateTime _acmi_dFechaExpedicion;
    
        [DataMember]
        public System.DateTime acmi_dFechaExpiracion
        {
            get { return _acmi_dFechaExpiracion; }
            set
            {
                if (_acmi_dFechaExpiracion != value)
                {
                    _acmi_dFechaExpiracion = value;
                    OnPropertyChanged("acmi_dFechaExpiracion");
                }
            }
        }
        private System.DateTime _acmi_dFechaExpiracion;
    
        [DataMember]
        public string acmi_vNumeroDocumento
        {
            get { return _acmi_vNumeroDocumento; }
            set
            {
                if (_acmi_vNumeroDocumento != value)
                {
                    _acmi_vNumeroDocumento = value;
                    OnPropertyChanged("acmi_vNumeroDocumento");
                }
            }
        }
        private string _acmi_vNumeroDocumento;
    
        [DataMember]
        public string acmi_vNumeroDocumentoAnterior
        {
            get { return _acmi_vNumeroDocumentoAnterior; }
            set
            {
                if (_acmi_vNumeroDocumentoAnterior != value)
                {
                    _acmi_vNumeroDocumentoAnterior = value;
                    OnPropertyChanged("acmi_vNumeroDocumentoAnterior");
                }
            }
        }
        private string _acmi_vNumeroDocumentoAnterior;
    
        [DataMember]
        public string acmi_vObservaciones
        {
            get { return _acmi_vObservaciones; }
            set
            {
                if (_acmi_vObservaciones != value)
                {
                    _acmi_vObservaciones = value;
                    OnPropertyChanged("acmi_vObservaciones");
                }
            }
        }
        private string _acmi_vObservaciones;
    
        [DataMember]
        public short acmi_sEstadoId
        {
            get { return _acmi_sEstadoId; }
            set
            {
                if (_acmi_sEstadoId != value)
                {
                    ChangeTracker.RecordOriginalValue("acmi_sEstadoId", _acmi_sEstadoId);
                    if (!IsDeserializing)
                    {
                        if (MA_ESTADO != null && MA_ESTADO.esta_sEstadoId != value)
                        {
                            MA_ESTADO = null;
                        }
                    }
                    _acmi_sEstadoId = value;
                    OnPropertyChanged("acmi_sEstadoId");
                }
            }
        }
        private short _acmi_sEstadoId;
    
        [DataMember]
        public short acmi_sUsuarioCreacion
        {
            get { return _acmi_sUsuarioCreacion; }
            set
            {
                if (_acmi_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("acmi_sUsuarioCreacion", _acmi_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _acmi_sUsuarioCreacion = value;
                    OnPropertyChanged("acmi_sUsuarioCreacion");
                }
            }
        }
        private short _acmi_sUsuarioCreacion;
    
        [DataMember]
        public string acmi_vIPCreacion
        {
            get { return _acmi_vIPCreacion; }
            set
            {
                if (_acmi_vIPCreacion != value)
                {
                    _acmi_vIPCreacion = value;
                    OnPropertyChanged("acmi_vIPCreacion");
                }
            }
        }
        private string _acmi_vIPCreacion;
    
        [DataMember]
        public System.DateTime acmi_dFechaCreacion
        {
            get { return _acmi_dFechaCreacion; }
            set
            {
                if (_acmi_dFechaCreacion != value)
                {
                    _acmi_dFechaCreacion = value;
                    OnPropertyChanged("acmi_dFechaCreacion");
                }
            }
        }
        private System.DateTime _acmi_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> acmi_sUsuarioModificacion
        {
            get { return _acmi_sUsuarioModificacion; }
            set
            {
                if (_acmi_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("acmi_sUsuarioModificacion", _acmi_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _acmi_sUsuarioModificacion = value;
                    OnPropertyChanged("acmi_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _acmi_sUsuarioModificacion;
    
        [DataMember]
        public string acmi_vIPModificacion
        {
            get { return _acmi_vIPModificacion; }
            set
            {
                if (_acmi_vIPModificacion != value)
                {
                    _acmi_vIPModificacion = value;
                    OnPropertyChanged("acmi_vIPModificacion");
                }
            }
        }
        private string _acmi_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> acmi_dFechaModificacion
        {
            get { return _acmi_dFechaModificacion; }
            set
            {
                if (_acmi_dFechaModificacion != value)
                {
                    _acmi_dFechaModificacion = value;
                    OnPropertyChanged("acmi_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _acmi_dFechaModificacion;

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
        public MA_ESTADO MA_ESTADO
        {
            get { return _mA_ESTADO; }
            set
            {
                if (!ReferenceEquals(_mA_ESTADO, value))
                {
                    var previousValue = _mA_ESTADO;
                    _mA_ESTADO = value;
                    FixupMA_ESTADO(previousValue);
                    OnNavigationPropertyChanged("MA_ESTADO");
                }
            }
        }
        private MA_ESTADO _mA_ESTADO;
    
        [DataMember]
        public RE_ACTUACIONDETALLE RE_ACTUACIONDETALLE
        {
            get { return _rE_ACTUACIONDETALLE; }
            set
            {
                if (!ReferenceEquals(_rE_ACTUACIONDETALLE, value))
                {
                    var previousValue = _rE_ACTUACIONDETALLE;
                    _rE_ACTUACIONDETALLE = value;
                    FixupRE_ACTUACIONDETALLE(previousValue);
                    OnNavigationPropertyChanged("RE_ACTUACIONDETALLE");
                }
            }
        }
        private RE_ACTUACIONDETALLE _rE_ACTUACIONDETALLE;
    
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
        public SI_PARAMETRO SI_PARAMETRO1
        {
            get { return _sI_PARAMETRO1; }
            set
            {
                if (!ReferenceEquals(_sI_PARAMETRO1, value))
                {
                    var previousValue = _sI_PARAMETRO1;
                    _sI_PARAMETRO1 = value;
                    FixupSI_PARAMETRO1(previousValue);
                    OnNavigationPropertyChanged("SI_PARAMETRO1");
                }
            }
        }
        private SI_PARAMETRO _sI_PARAMETRO1;
    
        [DataMember]
        public TrackableCollection<RE_ACTOMIGRATORIOFORMATO> RE_ACTOMIGRATORIOFORMATO
        {
            get
            {
                if (_rE_ACTOMIGRATORIOFORMATO == null)
                {
                    _rE_ACTOMIGRATORIOFORMATO = new TrackableCollection<RE_ACTOMIGRATORIOFORMATO>();
                    _rE_ACTOMIGRATORIOFORMATO.CollectionChanged += FixupRE_ACTOMIGRATORIOFORMATO;
                }
                return _rE_ACTOMIGRATORIOFORMATO;
            }
            set
            {
                if (!ReferenceEquals(_rE_ACTOMIGRATORIOFORMATO, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_rE_ACTOMIGRATORIOFORMATO != null)
                    {
                        _rE_ACTOMIGRATORIOFORMATO.CollectionChanged -= FixupRE_ACTOMIGRATORIOFORMATO;
                    }
                    _rE_ACTOMIGRATORIOFORMATO = value;
                    if (_rE_ACTOMIGRATORIOFORMATO != null)
                    {
                        _rE_ACTOMIGRATORIOFORMATO.CollectionChanged += FixupRE_ACTOMIGRATORIOFORMATO;
                    }
                    OnNavigationPropertyChanged("RE_ACTOMIGRATORIOFORMATO");
                }
            }
        }
        private TrackableCollection<RE_ACTOMIGRATORIOFORMATO> _rE_ACTOMIGRATORIOFORMATO;
    
        [DataMember]
        public TrackableCollection<RE_ACTOMIGRATORIOHISTORICO> RE_ACTOMIGRATORIOHISTORICO
        {
            get
            {
                if (_rE_ACTOMIGRATORIOHISTORICO == null)
                {
                    _rE_ACTOMIGRATORIOHISTORICO = new TrackableCollection<RE_ACTOMIGRATORIOHISTORICO>();
                    _rE_ACTOMIGRATORIOHISTORICO.CollectionChanged += FixupRE_ACTOMIGRATORIOHISTORICO;
                }
                return _rE_ACTOMIGRATORIOHISTORICO;
            }
            set
            {
                if (!ReferenceEquals(_rE_ACTOMIGRATORIOHISTORICO, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_rE_ACTOMIGRATORIOHISTORICO != null)
                    {
                        _rE_ACTOMIGRATORIOHISTORICO.CollectionChanged -= FixupRE_ACTOMIGRATORIOHISTORICO;
                    }
                    _rE_ACTOMIGRATORIOHISTORICO = value;
                    if (_rE_ACTOMIGRATORIOHISTORICO != null)
                    {
                        _rE_ACTOMIGRATORIOHISTORICO.CollectionChanged += FixupRE_ACTOMIGRATORIOHISTORICO;
                    }
                    OnNavigationPropertyChanged("RE_ACTOMIGRATORIOHISTORICO");
                }
            }
        }
        private TrackableCollection<RE_ACTOMIGRATORIOHISTORICO> _rE_ACTOMIGRATORIOHISTORICO;
    
        [DataMember]
        public SI_PARAMETRO SI_PARAMETRO2
        {
            get { return _sI_PARAMETRO2; }
            set
            {
                if (!ReferenceEquals(_sI_PARAMETRO2, value))
                {
                    var previousValue = _sI_PARAMETRO2;
                    _sI_PARAMETRO2 = value;
                    FixupSI_PARAMETRO2(previousValue);
                    OnNavigationPropertyChanged("SI_PARAMETRO2");
                }
            }
        }
        private SI_PARAMETRO _sI_PARAMETRO2;

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
            MA_ESTADO = null;
            RE_ACTUACIONDETALLE = null;
            SE_USUARIO = null;
            SE_USUARIO1 = null;
            SI_PARAMETRO = null;
            SI_PARAMETRO1 = null;
            RE_ACTOMIGRATORIOFORMATO.Clear();
            RE_ACTOMIGRATORIOHISTORICO.Clear();
            SI_PARAMETRO2 = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupMA_DOCUMENTO_IDENTIDAD(MA_DOCUMENTO_IDENTIDAD previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_ACTOMIGRATORIO.Contains(this))
            {
                previousValue.RE_ACTOMIGRATORIO.Remove(this);
            }
    
            if (MA_DOCUMENTO_IDENTIDAD != null)
            {
                if (!MA_DOCUMENTO_IDENTIDAD.RE_ACTOMIGRATORIO.Contains(this))
                {
                    MA_DOCUMENTO_IDENTIDAD.RE_ACTOMIGRATORIO.Add(this);
                }
    
                acmi_sTipoDocumentoMigratorioId = MA_DOCUMENTO_IDENTIDAD.doid_sTipoDocumentoIdentidadId;
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
    
        private void FixupMA_ESTADO(MA_ESTADO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_ACTOMIGRATORIO.Contains(this))
            {
                previousValue.RE_ACTOMIGRATORIO.Remove(this);
            }
    
            if (MA_ESTADO != null)
            {
                if (!MA_ESTADO.RE_ACTOMIGRATORIO.Contains(this))
                {
                    MA_ESTADO.RE_ACTOMIGRATORIO.Add(this);
                }
    
                acmi_sEstadoId = MA_ESTADO.esta_sEstadoId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("MA_ESTADO")
                    && (ChangeTracker.OriginalValues["MA_ESTADO"] == MA_ESTADO))
                {
                    ChangeTracker.OriginalValues.Remove("MA_ESTADO");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("MA_ESTADO", previousValue);
                }
                if (MA_ESTADO != null && !MA_ESTADO.ChangeTracker.ChangeTrackingEnabled)
                {
                    MA_ESTADO.StartTracking();
                }
            }
        }
    
        private void FixupRE_ACTUACIONDETALLE(RE_ACTUACIONDETALLE previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_ACTOMIGRATORIO.Contains(this))
            {
                previousValue.RE_ACTOMIGRATORIO.Remove(this);
            }
    
            if (RE_ACTUACIONDETALLE != null)
            {
                if (!RE_ACTUACIONDETALLE.RE_ACTOMIGRATORIO.Contains(this))
                {
                    RE_ACTUACIONDETALLE.RE_ACTOMIGRATORIO.Add(this);
                }
    
                acmi_iActuacionDetalleId = RE_ACTUACIONDETALLE.acde_iActuacionDetalleId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("RE_ACTUACIONDETALLE")
                    && (ChangeTracker.OriginalValues["RE_ACTUACIONDETALLE"] == RE_ACTUACIONDETALLE))
                {
                    ChangeTracker.OriginalValues.Remove("RE_ACTUACIONDETALLE");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("RE_ACTUACIONDETALLE", previousValue);
                }
                if (RE_ACTUACIONDETALLE != null && !RE_ACTUACIONDETALLE.ChangeTracker.ChangeTrackingEnabled)
                {
                    RE_ACTUACIONDETALLE.StartTracking();
                }
            }
        }
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_ACTOMIGRATORIO.Contains(this))
            {
                previousValue.RE_ACTOMIGRATORIO.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.RE_ACTOMIGRATORIO.Contains(this))
                {
                    SE_USUARIO.RE_ACTOMIGRATORIO.Add(this);
                }
    
                acmi_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.RE_ACTOMIGRATORIO1.Contains(this))
            {
                previousValue.RE_ACTOMIGRATORIO1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.RE_ACTOMIGRATORIO1.Contains(this))
                {
                    SE_USUARIO1.RE_ACTOMIGRATORIO1.Add(this);
                }
    
                acmi_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                acmi_sUsuarioModificacion = null;
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
    
            if (previousValue != null && previousValue.RE_ACTOMIGRATORIO.Contains(this))
            {
                previousValue.RE_ACTOMIGRATORIO.Remove(this);
            }
    
            if (SI_PARAMETRO != null)
            {
                if (!SI_PARAMETRO.RE_ACTOMIGRATORIO.Contains(this))
                {
                    SI_PARAMETRO.RE_ACTOMIGRATORIO.Add(this);
                }
    
                acmi_sTipoId = SI_PARAMETRO.para_sParametroId;
            }
            else if (!skipKeys)
            {
                acmi_sTipoId = null;
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
    
        private void FixupSI_PARAMETRO1(SI_PARAMETRO previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_ACTOMIGRATORIO1.Contains(this))
            {
                previousValue.RE_ACTOMIGRATORIO1.Remove(this);
            }
    
            if (SI_PARAMETRO1 != null)
            {
                if (!SI_PARAMETRO1.RE_ACTOMIGRATORIO1.Contains(this))
                {
                    SI_PARAMETRO1.RE_ACTOMIGRATORIO1.Add(this);
                }
    
                acmi_sSubTipoId = SI_PARAMETRO1.para_sParametroId;
            }
            else if (!skipKeys)
            {
                acmi_sSubTipoId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SI_PARAMETRO1")
                    && (ChangeTracker.OriginalValues["SI_PARAMETRO1"] == SI_PARAMETRO1))
                {
                    ChangeTracker.OriginalValues.Remove("SI_PARAMETRO1");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SI_PARAMETRO1", previousValue);
                }
                if (SI_PARAMETRO1 != null && !SI_PARAMETRO1.ChangeTracker.ChangeTrackingEnabled)
                {
                    SI_PARAMETRO1.StartTracking();
                }
            }
        }
    
        private void FixupSI_PARAMETRO2(SI_PARAMETRO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_ACTOMIGRATORIO2.Contains(this))
            {
                previousValue.RE_ACTOMIGRATORIO2.Remove(this);
            }
    
            if (SI_PARAMETRO2 != null)
            {
                if (!SI_PARAMETRO2.RE_ACTOMIGRATORIO2.Contains(this))
                {
                    SI_PARAMETRO2.RE_ACTOMIGRATORIO2.Add(this);
                }
    
                acmi_sTipoDocumentoMigratorioId = SI_PARAMETRO2.para_sParametroId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SI_PARAMETRO2")
                    && (ChangeTracker.OriginalValues["SI_PARAMETRO2"] == SI_PARAMETRO2))
                {
                    ChangeTracker.OriginalValues.Remove("SI_PARAMETRO2");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SI_PARAMETRO2", previousValue);
                }
                if (SI_PARAMETRO2 != null && !SI_PARAMETRO2.ChangeTracker.ChangeTrackingEnabled)
                {
                    SI_PARAMETRO2.StartTracking();
                }
            }
        }
    
        private void FixupRE_ACTOMIGRATORIOFORMATO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (RE_ACTOMIGRATORIOFORMATO item in e.NewItems)
                {
                    item.RE_ACTOMIGRATORIO = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("RE_ACTOMIGRATORIOFORMATO", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (RE_ACTOMIGRATORIOFORMATO item in e.OldItems)
                {
                    if (ReferenceEquals(item.RE_ACTOMIGRATORIO, this))
                    {
                        item.RE_ACTOMIGRATORIO = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("RE_ACTOMIGRATORIOFORMATO", item);
                    }
                }
            }
        }
    
        private void FixupRE_ACTOMIGRATORIOHISTORICO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (RE_ACTOMIGRATORIOHISTORICO item in e.NewItems)
                {
                    item.RE_ACTOMIGRATORIO = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("RE_ACTOMIGRATORIOHISTORICO", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (RE_ACTOMIGRATORIOHISTORICO item in e.OldItems)
                {
                    if (ReferenceEquals(item.RE_ACTOMIGRATORIO, this))
                    {
                        item.RE_ACTOMIGRATORIO = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("RE_ACTOMIGRATORIOHISTORICO", item);
                    }
                }
            }
        }

        #endregion
    }
}
