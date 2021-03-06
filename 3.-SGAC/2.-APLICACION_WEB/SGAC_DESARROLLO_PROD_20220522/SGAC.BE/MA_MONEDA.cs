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
    [KnownType(typeof(CO_CUENTACORRIENTE))]
    [KnownType(typeof(CO_REMESA))]
    [KnownType(typeof(CO_REMESADETALLE))]
    [KnownType(typeof(CO_TRANSACCION))]
    [KnownType(typeof(SE_USUARIO))]
    [KnownType(typeof(SI_TIPOCAMBIO_BANCARIO))]
    [KnownType(typeof(SI_TIPOCAMBIO_CONSULAR))]
    [KnownType(typeof(RE_PAGO))]
    [KnownType(typeof(SI_OFICINACONSULAR))]
    [KnownType(typeof(RE_ASISTENCIA))]
    public partial class MA_MONEDA: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public short mone_sMonedaId
        {
            get { return _mone_sMonedaId; }
            set
            {
                if (_mone_sMonedaId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'mone_sMonedaId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _mone_sMonedaId = value;
                    OnPropertyChanged("mone_sMonedaId");
                }
            }
        }
        private short _mone_sMonedaId;
    
        [DataMember]
        public string mone_vNombre
        {
            get { return _mone_vNombre; }
            set
            {
                if (_mone_vNombre != value)
                {
                    _mone_vNombre = value;
                    OnPropertyChanged("mone_vNombre");
                }
            }
        }
        private string _mone_vNombre;
    
        [DataMember]
        public string mone_vDescripcion
        {
            get { return _mone_vDescripcion; }
            set
            {
                if (_mone_vDescripcion != value)
                {
                    _mone_vDescripcion = value;
                    OnPropertyChanged("mone_vDescripcion");
                }
            }
        }
        private string _mone_vDescripcion;
    
        [DataMember]
        public string mone_vSimbolo
        {
            get { return _mone_vSimbolo; }
            set
            {
                if (_mone_vSimbolo != value)
                {
                    _mone_vSimbolo = value;
                    OnPropertyChanged("mone_vSimbolo");
                }
            }
        }
        private string _mone_vSimbolo;
    
        [DataMember]
        public string mone_vCodigo
        {
            get { return _mone_vCodigo; }
            set
            {
                if (_mone_vCodigo != value)
                {
                    _mone_vCodigo = value;
                    OnPropertyChanged("mone_vCodigo");
                }
            }
        }
        private string _mone_vCodigo;
    
        [DataMember]
        public string mone_cEstado
        {
            get { return _mone_cEstado; }
            set
            {
                if (_mone_cEstado != value)
                {
                    _mone_cEstado = value;
                    OnPropertyChanged("mone_cEstado");
                }
            }
        }
        private string _mone_cEstado;
    
        [DataMember]
        public short mone_sUsuarioCreacion
        {
            get { return _mone_sUsuarioCreacion; }
            set
            {
                if (_mone_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("mone_sUsuarioCreacion", _mone_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _mone_sUsuarioCreacion = value;
                    OnPropertyChanged("mone_sUsuarioCreacion");
                }
            }
        }
        private short _mone_sUsuarioCreacion;
    
        [DataMember]
        public string mone_vIPCreacion
        {
            get { return _mone_vIPCreacion; }
            set
            {
                if (_mone_vIPCreacion != value)
                {
                    _mone_vIPCreacion = value;
                    OnPropertyChanged("mone_vIPCreacion");
                }
            }
        }
        private string _mone_vIPCreacion;
    
        [DataMember]
        public System.DateTime mone_dFechaCreacion
        {
            get { return _mone_dFechaCreacion; }
            set
            {
                if (_mone_dFechaCreacion != value)
                {
                    _mone_dFechaCreacion = value;
                    OnPropertyChanged("mone_dFechaCreacion");
                }
            }
        }
        private System.DateTime _mone_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> mone_sUsuarioModificacion
        {
            get { return _mone_sUsuarioModificacion; }
            set
            {
                if (_mone_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("mone_sUsuarioModificacion", _mone_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _mone_sUsuarioModificacion = value;
                    OnPropertyChanged("mone_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _mone_sUsuarioModificacion;
    
        [DataMember]
        public string mone_vIPModificacion
        {
            get { return _mone_vIPModificacion; }
            set
            {
                if (_mone_vIPModificacion != value)
                {
                    _mone_vIPModificacion = value;
                    OnPropertyChanged("mone_vIPModificacion");
                }
            }
        }
        private string _mone_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> mone_dFechaModificacion
        {
            get { return _mone_dFechaModificacion; }
            set
            {
                if (_mone_dFechaModificacion != value)
                {
                    _mone_dFechaModificacion = value;
                    OnPropertyChanged("mone_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _mone_dFechaModificacion;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<CO_CUENTACORRIENTE> CO_CUENTACORRIENTE
        {
            get
            {
                if (_cO_CUENTACORRIENTE == null)
                {
                    _cO_CUENTACORRIENTE = new TrackableCollection<CO_CUENTACORRIENTE>();
                    _cO_CUENTACORRIENTE.CollectionChanged += FixupCO_CUENTACORRIENTE;
                }
                return _cO_CUENTACORRIENTE;
            }
            set
            {
                if (!ReferenceEquals(_cO_CUENTACORRIENTE, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_cO_CUENTACORRIENTE != null)
                    {
                        _cO_CUENTACORRIENTE.CollectionChanged -= FixupCO_CUENTACORRIENTE;
                    }
                    _cO_CUENTACORRIENTE = value;
                    if (_cO_CUENTACORRIENTE != null)
                    {
                        _cO_CUENTACORRIENTE.CollectionChanged += FixupCO_CUENTACORRIENTE;
                    }
                    OnNavigationPropertyChanged("CO_CUENTACORRIENTE");
                }
            }
        }
        private TrackableCollection<CO_CUENTACORRIENTE> _cO_CUENTACORRIENTE;
    
        [DataMember]
        public TrackableCollection<CO_REMESA> CO_REMESA
        {
            get
            {
                if (_cO_REMESA == null)
                {
                    _cO_REMESA = new TrackableCollection<CO_REMESA>();
                    _cO_REMESA.CollectionChanged += FixupCO_REMESA;
                }
                return _cO_REMESA;
            }
            set
            {
                if (!ReferenceEquals(_cO_REMESA, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_cO_REMESA != null)
                    {
                        _cO_REMESA.CollectionChanged -= FixupCO_REMESA;
                    }
                    _cO_REMESA = value;
                    if (_cO_REMESA != null)
                    {
                        _cO_REMESA.CollectionChanged += FixupCO_REMESA;
                    }
                    OnNavigationPropertyChanged("CO_REMESA");
                }
            }
        }
        private TrackableCollection<CO_REMESA> _cO_REMESA;
    
        [DataMember]
        public TrackableCollection<CO_REMESADETALLE> CO_REMESADETALLE
        {
            get
            {
                if (_cO_REMESADETALLE == null)
                {
                    _cO_REMESADETALLE = new TrackableCollection<CO_REMESADETALLE>();
                    _cO_REMESADETALLE.CollectionChanged += FixupCO_REMESADETALLE;
                }
                return _cO_REMESADETALLE;
            }
            set
            {
                if (!ReferenceEquals(_cO_REMESADETALLE, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_cO_REMESADETALLE != null)
                    {
                        _cO_REMESADETALLE.CollectionChanged -= FixupCO_REMESADETALLE;
                    }
                    _cO_REMESADETALLE = value;
                    if (_cO_REMESADETALLE != null)
                    {
                        _cO_REMESADETALLE.CollectionChanged += FixupCO_REMESADETALLE;
                    }
                    OnNavigationPropertyChanged("CO_REMESADETALLE");
                }
            }
        }
        private TrackableCollection<CO_REMESADETALLE> _cO_REMESADETALLE;
    
        [DataMember]
        public TrackableCollection<CO_TRANSACCION> CO_TRANSACCION
        {
            get
            {
                if (_cO_TRANSACCION == null)
                {
                    _cO_TRANSACCION = new TrackableCollection<CO_TRANSACCION>();
                    _cO_TRANSACCION.CollectionChanged += FixupCO_TRANSACCION;
                }
                return _cO_TRANSACCION;
            }
            set
            {
                if (!ReferenceEquals(_cO_TRANSACCION, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_cO_TRANSACCION != null)
                    {
                        _cO_TRANSACCION.CollectionChanged -= FixupCO_TRANSACCION;
                    }
                    _cO_TRANSACCION = value;
                    if (_cO_TRANSACCION != null)
                    {
                        _cO_TRANSACCION.CollectionChanged += FixupCO_TRANSACCION;
                    }
                    OnNavigationPropertyChanged("CO_TRANSACCION");
                }
            }
        }
        private TrackableCollection<CO_TRANSACCION> _cO_TRANSACCION;
    
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
        public TrackableCollection<SI_TIPOCAMBIO_BANCARIO> SI_TIPOCAMBIO_BANCARIO
        {
            get
            {
                if (_sI_TIPOCAMBIO_BANCARIO == null)
                {
                    _sI_TIPOCAMBIO_BANCARIO = new TrackableCollection<SI_TIPOCAMBIO_BANCARIO>();
                    _sI_TIPOCAMBIO_BANCARIO.CollectionChanged += FixupSI_TIPOCAMBIO_BANCARIO;
                }
                return _sI_TIPOCAMBIO_BANCARIO;
            }
            set
            {
                if (!ReferenceEquals(_sI_TIPOCAMBIO_BANCARIO, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_sI_TIPOCAMBIO_BANCARIO != null)
                    {
                        _sI_TIPOCAMBIO_BANCARIO.CollectionChanged -= FixupSI_TIPOCAMBIO_BANCARIO;
                    }
                    _sI_TIPOCAMBIO_BANCARIO = value;
                    if (_sI_TIPOCAMBIO_BANCARIO != null)
                    {
                        _sI_TIPOCAMBIO_BANCARIO.CollectionChanged += FixupSI_TIPOCAMBIO_BANCARIO;
                    }
                    OnNavigationPropertyChanged("SI_TIPOCAMBIO_BANCARIO");
                }
            }
        }
        private TrackableCollection<SI_TIPOCAMBIO_BANCARIO> _sI_TIPOCAMBIO_BANCARIO;
    
        [DataMember]
        public TrackableCollection<SI_TIPOCAMBIO_CONSULAR> SI_TIPOCAMBIO_CONSULAR
        {
            get
            {
                if (_sI_TIPOCAMBIO_CONSULAR == null)
                {
                    _sI_TIPOCAMBIO_CONSULAR = new TrackableCollection<SI_TIPOCAMBIO_CONSULAR>();
                    _sI_TIPOCAMBIO_CONSULAR.CollectionChanged += FixupSI_TIPOCAMBIO_CONSULAR;
                }
                return _sI_TIPOCAMBIO_CONSULAR;
            }
            set
            {
                if (!ReferenceEquals(_sI_TIPOCAMBIO_CONSULAR, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_sI_TIPOCAMBIO_CONSULAR != null)
                    {
                        _sI_TIPOCAMBIO_CONSULAR.CollectionChanged -= FixupSI_TIPOCAMBIO_CONSULAR;
                    }
                    _sI_TIPOCAMBIO_CONSULAR = value;
                    if (_sI_TIPOCAMBIO_CONSULAR != null)
                    {
                        _sI_TIPOCAMBIO_CONSULAR.CollectionChanged += FixupSI_TIPOCAMBIO_CONSULAR;
                    }
                    OnNavigationPropertyChanged("SI_TIPOCAMBIO_CONSULAR");
                }
            }
        }
        private TrackableCollection<SI_TIPOCAMBIO_CONSULAR> _sI_TIPOCAMBIO_CONSULAR;
    
        [DataMember]
        public TrackableCollection<RE_PAGO> RE_PAGO
        {
            get
            {
                if (_rE_PAGO == null)
                {
                    _rE_PAGO = new TrackableCollection<RE_PAGO>();
                    _rE_PAGO.CollectionChanged += FixupRE_PAGO;
                }
                return _rE_PAGO;
            }
            set
            {
                if (!ReferenceEquals(_rE_PAGO, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_rE_PAGO != null)
                    {
                        _rE_PAGO.CollectionChanged -= FixupRE_PAGO;
                    }
                    _rE_PAGO = value;
                    if (_rE_PAGO != null)
                    {
                        _rE_PAGO.CollectionChanged += FixupRE_PAGO;
                    }
                    OnNavigationPropertyChanged("RE_PAGO");
                }
            }
        }
        private TrackableCollection<RE_PAGO> _rE_PAGO;
    
        [DataMember]
        public TrackableCollection<SI_OFICINACONSULAR> SI_OFICINACONSULAR
        {
            get
            {
                if (_sI_OFICINACONSULAR == null)
                {
                    _sI_OFICINACONSULAR = new TrackableCollection<SI_OFICINACONSULAR>();
                    _sI_OFICINACONSULAR.CollectionChanged += FixupSI_OFICINACONSULAR;
                }
                return _sI_OFICINACONSULAR;
            }
            set
            {
                if (!ReferenceEquals(_sI_OFICINACONSULAR, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_sI_OFICINACONSULAR != null)
                    {
                        _sI_OFICINACONSULAR.CollectionChanged -= FixupSI_OFICINACONSULAR;
                    }
                    _sI_OFICINACONSULAR = value;
                    if (_sI_OFICINACONSULAR != null)
                    {
                        _sI_OFICINACONSULAR.CollectionChanged += FixupSI_OFICINACONSULAR;
                    }
                    OnNavigationPropertyChanged("SI_OFICINACONSULAR");
                }
            }
        }
        private TrackableCollection<SI_OFICINACONSULAR> _sI_OFICINACONSULAR;
    
        [DataMember]
        public TrackableCollection<RE_ASISTENCIA> RE_ASISTENCIA
        {
            get
            {
                if (_rE_ASISTENCIA == null)
                {
                    _rE_ASISTENCIA = new TrackableCollection<RE_ASISTENCIA>();
                    _rE_ASISTENCIA.CollectionChanged += FixupRE_ASISTENCIA;
                }
                return _rE_ASISTENCIA;
            }
            set
            {
                if (!ReferenceEquals(_rE_ASISTENCIA, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_rE_ASISTENCIA != null)
                    {
                        _rE_ASISTENCIA.CollectionChanged -= FixupRE_ASISTENCIA;
                    }
                    _rE_ASISTENCIA = value;
                    if (_rE_ASISTENCIA != null)
                    {
                        _rE_ASISTENCIA.CollectionChanged += FixupRE_ASISTENCIA;
                    }
                    OnNavigationPropertyChanged("RE_ASISTENCIA");
                }
            }
        }
        private TrackableCollection<RE_ASISTENCIA> _rE_ASISTENCIA;

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
            CO_CUENTACORRIENTE.Clear();
            CO_REMESA.Clear();
            CO_REMESADETALLE.Clear();
            CO_TRANSACCION.Clear();
            SE_USUARIO = null;
            SE_USUARIO1 = null;
            SI_TIPOCAMBIO_BANCARIO.Clear();
            SI_TIPOCAMBIO_CONSULAR.Clear();
            RE_PAGO.Clear();
            SI_OFICINACONSULAR.Clear();
            RE_ASISTENCIA.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.MA_MONEDA.Contains(this))
            {
                previousValue.MA_MONEDA.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.MA_MONEDA.Contains(this))
                {
                    SE_USUARIO.MA_MONEDA.Add(this);
                }
    
                mone_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.MA_MONEDA1.Contains(this))
            {
                previousValue.MA_MONEDA1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.MA_MONEDA1.Contains(this))
                {
                    SE_USUARIO1.MA_MONEDA1.Add(this);
                }
    
                mone_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                mone_sUsuarioModificacion = null;
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
    
        private void FixupCO_CUENTACORRIENTE(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (CO_CUENTACORRIENTE item in e.NewItems)
                {
                    item.MA_MONEDA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("CO_CUENTACORRIENTE", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CO_CUENTACORRIENTE item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_MONEDA, this))
                    {
                        item.MA_MONEDA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("CO_CUENTACORRIENTE", item);
                    }
                }
            }
        }
    
        private void FixupCO_REMESA(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (CO_REMESA item in e.NewItems)
                {
                    item.MA_MONEDA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("CO_REMESA", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CO_REMESA item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_MONEDA, this))
                    {
                        item.MA_MONEDA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("CO_REMESA", item);
                    }
                }
            }
        }
    
        private void FixupCO_REMESADETALLE(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (CO_REMESADETALLE item in e.NewItems)
                {
                    item.MA_MONEDA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("CO_REMESADETALLE", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CO_REMESADETALLE item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_MONEDA, this))
                    {
                        item.MA_MONEDA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("CO_REMESADETALLE", item);
                    }
                }
            }
        }
    
        private void FixupCO_TRANSACCION(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (CO_TRANSACCION item in e.NewItems)
                {
                    item.MA_MONEDA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("CO_TRANSACCION", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CO_TRANSACCION item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_MONEDA, this))
                    {
                        item.MA_MONEDA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("CO_TRANSACCION", item);
                    }
                }
            }
        }
    
        private void FixupSI_TIPOCAMBIO_BANCARIO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (SI_TIPOCAMBIO_BANCARIO item in e.NewItems)
                {
                    item.MA_MONEDA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("SI_TIPOCAMBIO_BANCARIO", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (SI_TIPOCAMBIO_BANCARIO item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_MONEDA, this))
                    {
                        item.MA_MONEDA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("SI_TIPOCAMBIO_BANCARIO", item);
                    }
                }
            }
        }
    
        private void FixupSI_TIPOCAMBIO_CONSULAR(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (SI_TIPOCAMBIO_CONSULAR item in e.NewItems)
                {
                    item.MA_MONEDA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("SI_TIPOCAMBIO_CONSULAR", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (SI_TIPOCAMBIO_CONSULAR item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_MONEDA, this))
                    {
                        item.MA_MONEDA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("SI_TIPOCAMBIO_CONSULAR", item);
                    }
                }
            }
        }
    
        private void FixupRE_PAGO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (RE_PAGO item in e.NewItems)
                {
                    item.MA_MONEDA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("RE_PAGO", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (RE_PAGO item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_MONEDA, this))
                    {
                        item.MA_MONEDA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("RE_PAGO", item);
                    }
                }
            }
        }
    
        private void FixupSI_OFICINACONSULAR(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (SI_OFICINACONSULAR item in e.NewItems)
                {
                    item.MA_MONEDA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("SI_OFICINACONSULAR", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (SI_OFICINACONSULAR item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_MONEDA, this))
                    {
                        item.MA_MONEDA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("SI_OFICINACONSULAR", item);
                    }
                }
            }
        }
    
        private void FixupRE_ASISTENCIA(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (RE_ASISTENCIA item in e.NewItems)
                {
                    item.MA_MONEDA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("RE_ASISTENCIA", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (RE_ASISTENCIA item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_MONEDA, this))
                    {
                        item.MA_MONEDA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("RE_ASISTENCIA", item);
                    }
                }
            }
        }

        #endregion
    }
}
