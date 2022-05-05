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
    [KnownType(typeof(AL_MOVIMIENTO))]
    [KnownType(typeof(MA_ESTADO))]
    [KnownType(typeof(SE_USUARIO))]
    [KnownType(typeof(SI_PARAMETRO))]
    [KnownType(typeof(AL_INSUMOHISTORICO))]
    [KnownType(typeof(RE_ACTUACIONINSUMODETALLE))]
    public partial class AL_INSUMO: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public long insu_iInsumoId
        {
            get { return _insu_iInsumoId; }
            set
            {
                if (_insu_iInsumoId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'insu_iInsumoId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _insu_iInsumoId = value;
                    OnPropertyChanged("insu_iInsumoId");
                }
            }
        }
        private long _insu_iInsumoId;
    
        [DataMember]
        public long insu_iMovimientoId
        {
            get { return _insu_iMovimientoId; }
            set
            {
                if (_insu_iMovimientoId != value)
                {
                    ChangeTracker.RecordOriginalValue("insu_iMovimientoId", _insu_iMovimientoId);
                    if (!IsDeserializing)
                    {
                        if (AL_MOVIMIENTO != null && AL_MOVIMIENTO.movi_iMovimientoId != value)
                        {
                            AL_MOVIMIENTO = null;
                        }
                    }
                    _insu_iMovimientoId = value;
                    OnPropertyChanged("insu_iMovimientoId");
                }
            }
        }
        private long _insu_iMovimientoId;
    
        [DataMember]
        public short insu_sInsumoTipoId
        {
            get { return _insu_sInsumoTipoId; }
            set
            {
                if (_insu_sInsumoTipoId != value)
                {
                    ChangeTracker.RecordOriginalValue("insu_sInsumoTipoId", _insu_sInsumoTipoId);
                    if (!IsDeserializing)
                    {
                        if (SI_PARAMETRO != null && SI_PARAMETRO.para_sParametroId != value)
                        {
                            SI_PARAMETRO = null;
                        }
                    }
                    _insu_sInsumoTipoId = value;
                    OnPropertyChanged("insu_sInsumoTipoId");
                }
            }
        }
        private short _insu_sInsumoTipoId;
    
        [DataMember]
        public string insu_vPrefijoNumeracion
        {
            get { return _insu_vPrefijoNumeracion; }
            set
            {
                if (_insu_vPrefijoNumeracion != value)
                {
                    _insu_vPrefijoNumeracion = value;
                    OnPropertyChanged("insu_vPrefijoNumeracion");
                }
            }
        }
        private string _insu_vPrefijoNumeracion;
    
        [DataMember]
        public string insu_vCodigoUnicoFabrica
        {
            get { return _insu_vCodigoUnicoFabrica; }
            set
            {
                if (_insu_vCodigoUnicoFabrica != value)
                {
                    _insu_vCodigoUnicoFabrica = value;
                    OnPropertyChanged("insu_vCodigoUnicoFabrica");
                }
            }
        }
        private string _insu_vCodigoUnicoFabrica;
    
        [DataMember]
        public Nullable<System.DateTime> insu_dFechaRegistro
        {
            get { return _insu_dFechaRegistro; }
            set
            {
                if (_insu_dFechaRegistro != value)
                {
                    _insu_dFechaRegistro = value;
                    OnPropertyChanged("insu_dFechaRegistro");
                }
            }
        }
        private Nullable<System.DateTime> _insu_dFechaRegistro;
    
        [DataMember]
        public short insu_sEstadoId
        {
            get { return _insu_sEstadoId; }
            set
            {
                if (_insu_sEstadoId != value)
                {
                    ChangeTracker.RecordOriginalValue("insu_sEstadoId", _insu_sEstadoId);
                    if (!IsDeserializing)
                    {
                        if (MA_ESTADO != null && MA_ESTADO.esta_sEstadoId != value)
                        {
                            MA_ESTADO = null;
                        }
                    }
                    _insu_sEstadoId = value;
                    OnPropertyChanged("insu_sEstadoId");
                }
            }
        }
        private short _insu_sEstadoId;
    
        [DataMember]
        public short insu_sUsuarioCreacion
        {
            get { return _insu_sUsuarioCreacion; }
            set
            {
                if (_insu_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("insu_sUsuarioCreacion", _insu_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _insu_sUsuarioCreacion = value;
                    OnPropertyChanged("insu_sUsuarioCreacion");
                }
            }
        }
        private short _insu_sUsuarioCreacion;
    
        [DataMember]
        public string insu_vIPCreacion
        {
            get { return _insu_vIPCreacion; }
            set
            {
                if (_insu_vIPCreacion != value)
                {
                    _insu_vIPCreacion = value;
                    OnPropertyChanged("insu_vIPCreacion");
                }
            }
        }
        private string _insu_vIPCreacion;
    
        [DataMember]
        public System.DateTime insu_dFechaCreacion
        {
            get { return _insu_dFechaCreacion; }
            set
            {
                if (_insu_dFechaCreacion != value)
                {
                    _insu_dFechaCreacion = value;
                    OnPropertyChanged("insu_dFechaCreacion");
                }
            }
        }
        private System.DateTime _insu_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> insu_sUsuarioModificacion
        {
            get { return _insu_sUsuarioModificacion; }
            set
            {
                if (_insu_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("insu_sUsuarioModificacion", _insu_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _insu_sUsuarioModificacion = value;
                    OnPropertyChanged("insu_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _insu_sUsuarioModificacion;
    
        [DataMember]
        public string insu_vIPModificacion
        {
            get { return _insu_vIPModificacion; }
            set
            {
                if (_insu_vIPModificacion != value)
                {
                    _insu_vIPModificacion = value;
                    OnPropertyChanged("insu_vIPModificacion");
                }
            }
        }
        private string _insu_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> insu_dFechaModificacion
        {
            get { return _insu_dFechaModificacion; }
            set
            {
                if (_insu_dFechaModificacion != value)
                {
                    _insu_dFechaModificacion = value;
                    OnPropertyChanged("insu_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _insu_dFechaModificacion;

        private string _insu_vMotivoBaja;

        [DataMember]
        public string insu_vMotivoBaja
        {
            get { return _insu_vMotivoBaja; }
            set
            {
                if (_insu_vMotivoBaja != value)
                {
                    _insu_vMotivoBaja = value;
                    OnPropertyChanged("insu_vMotivoBaja");
                }
            }
        }
        #endregion
        #region Navigation Properties
    
        [DataMember]
        public AL_MOVIMIENTO AL_MOVIMIENTO
        {
            get { return _aL_MOVIMIENTO; }
            set
            {
                if (!ReferenceEquals(_aL_MOVIMIENTO, value))
                {
                    var previousValue = _aL_MOVIMIENTO;
                    _aL_MOVIMIENTO = value;
                    FixupAL_MOVIMIENTO(previousValue);
                    OnNavigationPropertyChanged("AL_MOVIMIENTO");
                }
            }
        }
        private AL_MOVIMIENTO _aL_MOVIMIENTO;
    
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
        public TrackableCollection<AL_INSUMOHISTORICO> AL_INSUMOHISTORICO
        {
            get
            {
                if (_aL_INSUMOHISTORICO == null)
                {
                    _aL_INSUMOHISTORICO = new TrackableCollection<AL_INSUMOHISTORICO>();
                    _aL_INSUMOHISTORICO.CollectionChanged += FixupAL_INSUMOHISTORICO;
                }
                return _aL_INSUMOHISTORICO;
            }
            set
            {
                if (!ReferenceEquals(_aL_INSUMOHISTORICO, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_aL_INSUMOHISTORICO != null)
                    {
                        _aL_INSUMOHISTORICO.CollectionChanged -= FixupAL_INSUMOHISTORICO;
                    }
                    _aL_INSUMOHISTORICO = value;
                    if (_aL_INSUMOHISTORICO != null)
                    {
                        _aL_INSUMOHISTORICO.CollectionChanged += FixupAL_INSUMOHISTORICO;
                    }
                    OnNavigationPropertyChanged("AL_INSUMOHISTORICO");
                }
            }
        }
        private TrackableCollection<AL_INSUMOHISTORICO> _aL_INSUMOHISTORICO;
    
        [DataMember]
        public TrackableCollection<RE_ACTUACIONINSUMODETALLE> RE_ACTUACIONINSUMODETALLE
        {
            get
            {
                if (_rE_ACTUACIONINSUMODETALLE == null)
                {
                    _rE_ACTUACIONINSUMODETALLE = new TrackableCollection<RE_ACTUACIONINSUMODETALLE>();
                    _rE_ACTUACIONINSUMODETALLE.CollectionChanged += FixupRE_ACTUACIONINSUMODETALLE;
                }
                return _rE_ACTUACIONINSUMODETALLE;
            }
            set
            {
                if (!ReferenceEquals(_rE_ACTUACIONINSUMODETALLE, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_rE_ACTUACIONINSUMODETALLE != null)
                    {
                        _rE_ACTUACIONINSUMODETALLE.CollectionChanged -= FixupRE_ACTUACIONINSUMODETALLE;
                    }
                    _rE_ACTUACIONINSUMODETALLE = value;
                    if (_rE_ACTUACIONINSUMODETALLE != null)
                    {
                        _rE_ACTUACIONINSUMODETALLE.CollectionChanged += FixupRE_ACTUACIONINSUMODETALLE;
                    }
                    OnNavigationPropertyChanged("RE_ACTUACIONINSUMODETALLE");
                }
            }
        }
        private TrackableCollection<RE_ACTUACIONINSUMODETALLE> _rE_ACTUACIONINSUMODETALLE;

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
            AL_MOVIMIENTO = null;
            MA_ESTADO = null;
            SE_USUARIO = null;
            SE_USUARIO1 = null;
            SI_PARAMETRO = null;
            AL_INSUMOHISTORICO.Clear();
            RE_ACTUACIONINSUMODETALLE.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupAL_MOVIMIENTO(AL_MOVIMIENTO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.AL_INSUMO.Contains(this))
            {
                previousValue.AL_INSUMO.Remove(this);
            }
    
            if (AL_MOVIMIENTO != null)
            {
                if (!AL_MOVIMIENTO.AL_INSUMO.Contains(this))
                {
                    AL_MOVIMIENTO.AL_INSUMO.Add(this);
                }
    
                insu_iMovimientoId = AL_MOVIMIENTO.movi_iMovimientoId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("AL_MOVIMIENTO")
                    && (ChangeTracker.OriginalValues["AL_MOVIMIENTO"] == AL_MOVIMIENTO))
                {
                    ChangeTracker.OriginalValues.Remove("AL_MOVIMIENTO");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("AL_MOVIMIENTO", previousValue);
                }
                if (AL_MOVIMIENTO != null && !AL_MOVIMIENTO.ChangeTracker.ChangeTrackingEnabled)
                {
                    AL_MOVIMIENTO.StartTracking();
                }
            }
        }
    
        private void FixupMA_ESTADO(MA_ESTADO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.AL_INSUMO.Contains(this))
            {
                previousValue.AL_INSUMO.Remove(this);
            }
    
            if (MA_ESTADO != null)
            {
                if (!MA_ESTADO.AL_INSUMO.Contains(this))
                {
                    MA_ESTADO.AL_INSUMO.Add(this);
                }
    
                insu_sEstadoId = MA_ESTADO.esta_sEstadoId;
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
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.AL_INSUMO.Contains(this))
            {
                previousValue.AL_INSUMO.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.AL_INSUMO.Contains(this))
                {
                    SE_USUARIO.AL_INSUMO.Add(this);
                }
    
                insu_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.AL_INSUMO1.Contains(this))
            {
                previousValue.AL_INSUMO1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.AL_INSUMO1.Contains(this))
                {
                    SE_USUARIO1.AL_INSUMO1.Add(this);
                }
    
                insu_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                insu_sUsuarioModificacion = null;
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
    
        private void FixupSI_PARAMETRO(SI_PARAMETRO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.AL_INSUMO.Contains(this))
            {
                previousValue.AL_INSUMO.Remove(this);
            }
    
            if (SI_PARAMETRO != null)
            {
                if (!SI_PARAMETRO.AL_INSUMO.Contains(this))
                {
                    SI_PARAMETRO.AL_INSUMO.Add(this);
                }
    
                insu_sInsumoTipoId = SI_PARAMETRO.para_sParametroId;
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
    
        private void FixupAL_INSUMOHISTORICO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (AL_INSUMOHISTORICO item in e.NewItems)
                {
                    item.AL_INSUMO = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("AL_INSUMOHISTORICO", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (AL_INSUMOHISTORICO item in e.OldItems)
                {
                    if (ReferenceEquals(item.AL_INSUMO, this))
                    {
                        item.AL_INSUMO = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("AL_INSUMOHISTORICO", item);
                    }
                }
            }
        }
    
        private void FixupRE_ACTUACIONINSUMODETALLE(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (RE_ACTUACIONINSUMODETALLE item in e.NewItems)
                {
                    item.AL_INSUMO = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("RE_ACTUACIONINSUMODETALLE", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (RE_ACTUACIONINSUMODETALLE item in e.OldItems)
                {
                    if (ReferenceEquals(item.AL_INSUMO, this))
                    {
                        item.AL_INSUMO = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("RE_ACTUACIONINSUMODETALLE", item);
                    }
                }
            }
        }

        #endregion
    }
}
