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
    [KnownType(typeof(RE_ACTUACION))]
    [KnownType(typeof(RE_ACTUACIONDETALLE))]
    [KnownType(typeof(SE_USUARIO))]
    public partial class AL_MOVIMIENTODETALLE: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public long mode_iMovimientoDetalleId
        {
            get { return _mode_iMovimientoDetalleId; }
            set
            {
                if (_mode_iMovimientoDetalleId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'mode_iMovimientoDetalleId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _mode_iMovimientoDetalleId = value;
                    OnPropertyChanged("mode_iMovimientoDetalleId");
                }
            }
        }
        private long _mode_iMovimientoDetalleId;
    
        [DataMember]
        public long mode_iMovimientoId
        {
            get { return _mode_iMovimientoId; }
            set
            {
                if (_mode_iMovimientoId != value)
                {
                    ChangeTracker.RecordOriginalValue("mode_iMovimientoId", _mode_iMovimientoId);
                    if (!IsDeserializing)
                    {
                        if (AL_MOVIMIENTO != null && AL_MOVIMIENTO.movi_iMovimientoId != value)
                        {
                            AL_MOVIMIENTO = null;
                        }
                    }
                    _mode_iMovimientoId = value;
                    OnPropertyChanged("mode_iMovimientoId");
                }
            }
        }
        private long _mode_iMovimientoId;
    
        [DataMember]
        public Nullable<long> mode_iActuacionId
        {
            get { return _mode_iActuacionId; }
            set
            {
                if (_mode_iActuacionId != value)
                {
                    ChangeTracker.RecordOriginalValue("mode_iActuacionId", _mode_iActuacionId);
                    if (!IsDeserializing)
                    {
                        if (RE_ACTUACION != null && RE_ACTUACION.actu_iActuacionId != value)
                        {
                            RE_ACTUACION = null;
                        }
                    }
                    _mode_iActuacionId = value;
                    OnPropertyChanged("mode_iActuacionId");
                }
            }
        }
        private Nullable<long> _mode_iActuacionId;
    
        [DataMember]
        public Nullable<long> mode_iActuacionDetalleId
        {
            get { return _mode_iActuacionDetalleId; }
            set
            {
                if (_mode_iActuacionDetalleId != value)
                {
                    ChangeTracker.RecordOriginalValue("mode_iActuacionDetalleId", _mode_iActuacionDetalleId);
                    if (!IsDeserializing)
                    {
                        if (RE_ACTUACIONDETALLE != null && RE_ACTUACIONDETALLE.acde_iActuacionDetalleId != value)
                        {
                            RE_ACTUACIONDETALLE = null;
                        }
                    }
                    _mode_iActuacionDetalleId = value;
                    OnPropertyChanged("mode_iActuacionDetalleId");
                }
            }
        }
        private Nullable<long> _mode_iActuacionDetalleId;
    
        [DataMember]
        public string mode_vRangoInicial
        {
            get { return _mode_vRangoInicial; }
            set
            {
                if (_mode_vRangoInicial != value)
                {
                    _mode_vRangoInicial = value;
                    OnPropertyChanged("mode_vRangoInicial");
                }
            }
        }
        private string _mode_vRangoInicial;
    
        [DataMember]
        public string mode_vRangoFinal
        {
            get { return _mode_vRangoFinal; }
            set
            {
                if (_mode_vRangoFinal != value)
                {
                    _mode_vRangoFinal = value;
                    OnPropertyChanged("mode_vRangoFinal");
                }
            }
        }
        private string _mode_vRangoFinal;
    
        [DataMember]
        public int mode_ICantidad
        {
            get { return _mode_ICantidad; }
            set
            {
                if (_mode_ICantidad != value)
                {
                    _mode_ICantidad = value;
                    OnPropertyChanged("mode_ICantidad");
                }
            }
        }
        private int _mode_ICantidad;
    
        [DataMember]
        public string mode_vObservacion
        {
            get { return _mode_vObservacion; }
            set
            {
                if (_mode_vObservacion != value)
                {
                    _mode_vObservacion = value;
                    OnPropertyChanged("mode_vObservacion");
                }
            }
        }
        private string _mode_vObservacion;
    
        [DataMember]
        public short mode_sEstadoId
        {
            get { return _mode_sEstadoId; }
            set
            {
                if (_mode_sEstadoId != value)
                {
                    ChangeTracker.RecordOriginalValue("mode_sEstadoId", _mode_sEstadoId);
                    if (!IsDeserializing)
                    {
                        if (MA_ESTADO != null && MA_ESTADO.esta_sEstadoId != value)
                        {
                            MA_ESTADO = null;
                        }
                    }
                    _mode_sEstadoId = value;
                    OnPropertyChanged("mode_sEstadoId");
                }
            }
        }
        private short _mode_sEstadoId;
    
        [DataMember]
        public short mode_sUsuarioCreacion
        {
            get { return _mode_sUsuarioCreacion; }
            set
            {
                if (_mode_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("mode_sUsuarioCreacion", _mode_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _mode_sUsuarioCreacion = value;
                    OnPropertyChanged("mode_sUsuarioCreacion");
                }
            }
        }
        private short _mode_sUsuarioCreacion;
    
        [DataMember]
        public string mode_vIPCreacion
        {
            get { return _mode_vIPCreacion; }
            set
            {
                if (_mode_vIPCreacion != value)
                {
                    _mode_vIPCreacion = value;
                    OnPropertyChanged("mode_vIPCreacion");
                }
            }
        }
        private string _mode_vIPCreacion;
    
        [DataMember]
        public System.DateTime mode_dFechaCreacion
        {
            get { return _mode_dFechaCreacion; }
            set
            {
                if (_mode_dFechaCreacion != value)
                {
                    _mode_dFechaCreacion = value;
                    OnPropertyChanged("mode_dFechaCreacion");
                }
            }
        }
        private System.DateTime _mode_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> mode_sUsuarioModificacion
        {
            get { return _mode_sUsuarioModificacion; }
            set
            {
                if (_mode_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("mode_sUsuarioModificacion", _mode_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _mode_sUsuarioModificacion = value;
                    OnPropertyChanged("mode_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _mode_sUsuarioModificacion;
    
        [DataMember]
        public string mode_vIPModificacion
        {
            get { return _mode_vIPModificacion; }
            set
            {
                if (_mode_vIPModificacion != value)
                {
                    _mode_vIPModificacion = value;
                    OnPropertyChanged("mode_vIPModificacion");
                }
            }
        }
        private string _mode_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> mode_dFechaModificacion
        {
            get { return _mode_dFechaModificacion; }
            set
            {
                if (_mode_dFechaModificacion != value)
                {
                    _mode_dFechaModificacion = value;
                    OnPropertyChanged("mode_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _mode_dFechaModificacion;

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
        public RE_ACTUACION RE_ACTUACION
        {
            get { return _rE_ACTUACION; }
            set
            {
                if (!ReferenceEquals(_rE_ACTUACION, value))
                {
                    var previousValue = _rE_ACTUACION;
                    _rE_ACTUACION = value;
                    FixupRE_ACTUACION(previousValue);
                    OnNavigationPropertyChanged("RE_ACTUACION");
                }
            }
        }
        private RE_ACTUACION _rE_ACTUACION;
    
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
            RE_ACTUACION = null;
            RE_ACTUACIONDETALLE = null;
            SE_USUARIO = null;
            SE_USUARIO1 = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupAL_MOVIMIENTO(AL_MOVIMIENTO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.AL_MOVIMIENTODETALLE.Contains(this))
            {
                previousValue.AL_MOVIMIENTODETALLE.Remove(this);
            }
    
            if (AL_MOVIMIENTO != null)
            {
                if (!AL_MOVIMIENTO.AL_MOVIMIENTODETALLE.Contains(this))
                {
                    AL_MOVIMIENTO.AL_MOVIMIENTODETALLE.Add(this);
                }
    
                mode_iMovimientoId = AL_MOVIMIENTO.movi_iMovimientoId;
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
    
            if (previousValue != null && previousValue.AL_MOVIMIENTODETALLE.Contains(this))
            {
                previousValue.AL_MOVIMIENTODETALLE.Remove(this);
            }
    
            if (MA_ESTADO != null)
            {
                if (!MA_ESTADO.AL_MOVIMIENTODETALLE.Contains(this))
                {
                    MA_ESTADO.AL_MOVIMIENTODETALLE.Add(this);
                }
    
                mode_sEstadoId = MA_ESTADO.esta_sEstadoId;
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
    
        private void FixupRE_ACTUACION(RE_ACTUACION previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.AL_MOVIMIENTODETALLE.Contains(this))
            {
                previousValue.AL_MOVIMIENTODETALLE.Remove(this);
            }
    
            if (RE_ACTUACION != null)
            {
                if (!RE_ACTUACION.AL_MOVIMIENTODETALLE.Contains(this))
                {
                    RE_ACTUACION.AL_MOVIMIENTODETALLE.Add(this);
                }
    
                mode_iActuacionId = RE_ACTUACION.actu_iActuacionId;
            }
            else if (!skipKeys)
            {
                mode_iActuacionId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("RE_ACTUACION")
                    && (ChangeTracker.OriginalValues["RE_ACTUACION"] == RE_ACTUACION))
                {
                    ChangeTracker.OriginalValues.Remove("RE_ACTUACION");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("RE_ACTUACION", previousValue);
                }
                if (RE_ACTUACION != null && !RE_ACTUACION.ChangeTracker.ChangeTrackingEnabled)
                {
                    RE_ACTUACION.StartTracking();
                }
            }
        }
    
        private void FixupRE_ACTUACIONDETALLE(RE_ACTUACIONDETALLE previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.AL_MOVIMIENTODETALLE.Contains(this))
            {
                previousValue.AL_MOVIMIENTODETALLE.Remove(this);
            }
    
            if (RE_ACTUACIONDETALLE != null)
            {
                if (!RE_ACTUACIONDETALLE.AL_MOVIMIENTODETALLE.Contains(this))
                {
                    RE_ACTUACIONDETALLE.AL_MOVIMIENTODETALLE.Add(this);
                }
    
                mode_iActuacionDetalleId = RE_ACTUACIONDETALLE.acde_iActuacionDetalleId;
            }
            else if (!skipKeys)
            {
                mode_iActuacionDetalleId = null;
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
    
            if (previousValue != null && previousValue.AL_MOVIMIENTODETALLE.Contains(this))
            {
                previousValue.AL_MOVIMIENTODETALLE.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.AL_MOVIMIENTODETALLE.Contains(this))
                {
                    SE_USUARIO.AL_MOVIMIENTODETALLE.Add(this);
                }
    
                mode_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.AL_MOVIMIENTODETALLE1.Contains(this))
            {
                previousValue.AL_MOVIMIENTODETALLE1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.AL_MOVIMIENTODETALLE1.Contains(this))
                {
                    SE_USUARIO1.AL_MOVIMIENTODETALLE1.Add(this);
                }
    
                mode_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                mode_sUsuarioModificacion = null;
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

        #endregion
    }
}
