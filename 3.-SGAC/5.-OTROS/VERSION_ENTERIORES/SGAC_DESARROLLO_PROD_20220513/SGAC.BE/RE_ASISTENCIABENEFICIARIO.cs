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
    [KnownType(typeof(RE_ASISTENCIA))]
    public partial class RE_ASISTENCIABENEFICIARIO: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public long asbe_iAsistenciaBeneficiarioId
        {
            get { return _asbe_iAsistenciaBeneficiarioId; }
            set
            {
                if (_asbe_iAsistenciaBeneficiarioId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'asbe_iAsistenciaBeneficiarioId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _asbe_iAsistenciaBeneficiarioId = value;
                    OnPropertyChanged("asbe_iAsistenciaBeneficiarioId");
                }
            }
        }
        private long _asbe_iAsistenciaBeneficiarioId;
    
        [DataMember]
        public long asbe_iAsistenciaId
        {
            get { return _asbe_iAsistenciaId; }
            set
            {
                if (_asbe_iAsistenciaId != value)
                {
                    ChangeTracker.RecordOriginalValue("asbe_iAsistenciaId", _asbe_iAsistenciaId);
                    if (!IsDeserializing)
                    {
                        if (RE_ASISTENCIA != null && RE_ASISTENCIA.asis_iAsistenciaId != value)
                        {
                            RE_ASISTENCIA = null;
                        }
                    }
                    _asbe_iAsistenciaId = value;
                    OnPropertyChanged("asbe_iAsistenciaId");
                }
            }
        }
        private long _asbe_iAsistenciaId;
    
        [DataMember]
        public short asbe_sDocumentoTipoId
        {
            get { return _asbe_sDocumentoTipoId; }
            set
            {
                if (_asbe_sDocumentoTipoId != value)
                {
                    _asbe_sDocumentoTipoId = value;
                    OnPropertyChanged("asbe_sDocumentoTipoId");
                }
            }
        }
        private short _asbe_sDocumentoTipoId;
    
        [DataMember]
        public string asbe_vDocumentoNumero
        {
            get { return _asbe_vDocumentoNumero; }
            set
            {
                if (_asbe_vDocumentoNumero != value)
                {
                    _asbe_vDocumentoNumero = value;
                    OnPropertyChanged("asbe_vDocumentoNumero");
                }
            }
        }
        private string _asbe_vDocumentoNumero;
    
        [DataMember]
        public string asbe_vApellidoPaterno
        {
            get { return _asbe_vApellidoPaterno; }
            set
            {
                if (_asbe_vApellidoPaterno != value)
                {
                    _asbe_vApellidoPaterno = value;
                    OnPropertyChanged("asbe_vApellidoPaterno");
                }
            }
        }
        private string _asbe_vApellidoPaterno;
    
        [DataMember]
        public string asbe_vApellidoMaterno
        {
            get { return _asbe_vApellidoMaterno; }
            set
            {
                if (_asbe_vApellidoMaterno != value)
                {
                    _asbe_vApellidoMaterno = value;
                    OnPropertyChanged("asbe_vApellidoMaterno");
                }
            }
        }
        private string _asbe_vApellidoMaterno;
    
        [DataMember]
        public string asbe_vNombres
        {
            get { return _asbe_vNombres; }
            set
            {
                if (_asbe_vNombres != value)
                {
                    _asbe_vNombres = value;
                    OnPropertyChanged("asbe_vNombres");
                }
            }
        }
        private string _asbe_vNombres;
    
        [DataMember]
        public Nullable<double> asbe_FMonto
        {
            get { return _asbe_FMonto; }
            set
            {
                if (_asbe_FMonto != value)
                {
                    _asbe_FMonto = value;
                    OnPropertyChanged("asbe_FMonto");
                }
            }
        }
        private Nullable<double> _asbe_FMonto;
    
        [DataMember]
        public string asbe_cEstado
        {
            get { return _asbe_cEstado; }
            set
            {
                if (_asbe_cEstado != value)
                {
                    _asbe_cEstado = value;
                    OnPropertyChanged("asbe_cEstado");
                }
            }
        }
        private string _asbe_cEstado;
    
        [DataMember]
        public short asbe_sUsuarioCreacion
        {
            get { return _asbe_sUsuarioCreacion; }
            set
            {
                if (_asbe_sUsuarioCreacion != value)
                {
                    _asbe_sUsuarioCreacion = value;
                    OnPropertyChanged("asbe_sUsuarioCreacion");
                }
            }
        }
        private short _asbe_sUsuarioCreacion;
    
        [DataMember]
        public string asbe_vIPCreacion
        {
            get { return _asbe_vIPCreacion; }
            set
            {
                if (_asbe_vIPCreacion != value)
                {
                    _asbe_vIPCreacion = value;
                    OnPropertyChanged("asbe_vIPCreacion");
                }
            }
        }
        private string _asbe_vIPCreacion;
    
        [DataMember]
        public System.DateTime asbe_dFechaCreacion
        {
            get { return _asbe_dFechaCreacion; }
            set
            {
                if (_asbe_dFechaCreacion != value)
                {
                    _asbe_dFechaCreacion = value;
                    OnPropertyChanged("asbe_dFechaCreacion");
                }
            }
        }
        private System.DateTime _asbe_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> asbe_sUsuarioModificacion
        {
            get { return _asbe_sUsuarioModificacion; }
            set
            {
                if (_asbe_sUsuarioModificacion != value)
                {
                    _asbe_sUsuarioModificacion = value;
                    OnPropertyChanged("asbe_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _asbe_sUsuarioModificacion;
    
        [DataMember]
        public string asbe_vIPModificacion
        {
            get { return _asbe_vIPModificacion; }
            set
            {
                if (_asbe_vIPModificacion != value)
                {
                    _asbe_vIPModificacion = value;
                    OnPropertyChanged("asbe_vIPModificacion");
                }
            }
        }
        private string _asbe_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> asbe_dFechaModificacion
        {
            get { return _asbe_dFechaModificacion; }
            set
            {
                if (_asbe_dFechaModificacion != value)
                {
                    _asbe_dFechaModificacion = value;
                    OnPropertyChanged("asbe_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _asbe_dFechaModificacion;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public RE_ASISTENCIA RE_ASISTENCIA
        {
            get { return _rE_ASISTENCIA; }
            set
            {
                if (!ReferenceEquals(_rE_ASISTENCIA, value))
                {
                    var previousValue = _rE_ASISTENCIA;
                    _rE_ASISTENCIA = value;
                    FixupRE_ASISTENCIA(previousValue);
                    OnNavigationPropertyChanged("RE_ASISTENCIA");
                }
            }
        }
        private RE_ASISTENCIA _rE_ASISTENCIA;

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
            RE_ASISTENCIA = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupRE_ASISTENCIA(RE_ASISTENCIA previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_ASISTENCIABENEFICIARIO.Contains(this))
            {
                previousValue.RE_ASISTENCIABENEFICIARIO.Remove(this);
            }
    
            if (RE_ASISTENCIA != null)
            {
                if (!RE_ASISTENCIA.RE_ASISTENCIABENEFICIARIO.Contains(this))
                {
                    RE_ASISTENCIA.RE_ASISTENCIABENEFICIARIO.Add(this);
                }
    
                asbe_iAsistenciaId = RE_ASISTENCIA.asis_iAsistenciaId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("RE_ASISTENCIA")
                    && (ChangeTracker.OriginalValues["RE_ASISTENCIA"] == RE_ASISTENCIA))
                {
                    ChangeTracker.OriginalValues.Remove("RE_ASISTENCIA");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("RE_ASISTENCIA", previousValue);
                }
                if (RE_ASISTENCIA != null && !RE_ASISTENCIA.ChangeTracker.ChangeTrackingEnabled)
                {
                    RE_ASISTENCIA.StartTracking();
                }
            }
        }

        #endregion
    }
}