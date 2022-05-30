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
    [KnownType(typeof(CL_TICKET))]
    [KnownType(typeof(SE_USUARIO))]
    [KnownType(typeof(SI_PARAMETRO))]
    [KnownType(typeof(SI_OFICINACONSULAR))]
    public partial class CL_VENTANILLA: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public short vent_sVentanillaId
        {
            get { return _vent_sVentanillaId; }
            set
            {
                if (_vent_sVentanillaId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'vent_sVentanillaId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _vent_sVentanillaId = value;
                    OnPropertyChanged("vent_sVentanillaId");
                }
            }
        }
        private short _vent_sVentanillaId;
    
        [DataMember]
        public Nullable<short> vent_sOficinaConsularId
        {
            get { return _vent_sOficinaConsularId; }
            set
            {
                if (_vent_sOficinaConsularId != value)
                {
                    ChangeTracker.RecordOriginalValue("vent_sOficinaConsularId", _vent_sOficinaConsularId);
                    if (!IsDeserializing)
                    {
                        if (SI_OFICINACONSULAR != null && SI_OFICINACONSULAR.ofco_sOficinaConsularId != value)
                        {
                            SI_OFICINACONSULAR = null;
                        }
                    }
                    _vent_sOficinaConsularId = value;
                    OnPropertyChanged("vent_sOficinaConsularId");
                }
            }
        }
        private Nullable<short> _vent_sOficinaConsularId;
    
        [DataMember]
        public string vent_vDescripcion
        {
            get { return _vent_vDescripcion; }
            set
            {
                if (_vent_vDescripcion != value)
                {
                    _vent_vDescripcion = value;
                    OnPropertyChanged("vent_vDescripcion");
                }
            }
        }
        private string _vent_vDescripcion;
    
        [DataMember]
        public Nullable<int> vent_INumeroOrden
        {
            get { return _vent_INumeroOrden; }
            set
            {
                if (_vent_INumeroOrden != value)
                {
                    _vent_INumeroOrden = value;
                    OnPropertyChanged("vent_INumeroOrden");
                }
            }
        }
        private Nullable<int> _vent_INumeroOrden;
    
        [DataMember]
        public Nullable<short> vent_sSectorId
        {
            get { return _vent_sSectorId; }
            set
            {
                if (_vent_sSectorId != value)
                {
                    ChangeTracker.RecordOriginalValue("vent_sSectorId", _vent_sSectorId);
                    if (!IsDeserializing)
                    {
                        if (SI_PARAMETRO != null && SI_PARAMETRO.para_sParametroId != value)
                        {
                            SI_PARAMETRO = null;
                        }
                    }
                    _vent_sSectorId = value;
                    OnPropertyChanged("vent_sSectorId");
                }
            }
        }
        private Nullable<short> _vent_sSectorId;
    
        [DataMember]
        public string vent_cEstado
        {
            get { return _vent_cEstado; }
            set
            {
                if (_vent_cEstado != value)
                {
                    _vent_cEstado = value;
                    OnPropertyChanged("vent_cEstado");
                }
            }
        }
        private string _vent_cEstado;
    
        [DataMember]
        public short vent_sUsuarioCreacion
        {
            get { return _vent_sUsuarioCreacion; }
            set
            {
                if (_vent_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("vent_sUsuarioCreacion", _vent_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _vent_sUsuarioCreacion = value;
                    OnPropertyChanged("vent_sUsuarioCreacion");
                }
            }
        }
        private short _vent_sUsuarioCreacion;
    
        [DataMember]
        public string vent_vIPCreacion
        {
            get { return _vent_vIPCreacion; }
            set
            {
                if (_vent_vIPCreacion != value)
                {
                    _vent_vIPCreacion = value;
                    OnPropertyChanged("vent_vIPCreacion");
                }
            }
        }
        private string _vent_vIPCreacion;
    
        [DataMember]
        public System.DateTime vent_dFechaCreacion
        {
            get { return _vent_dFechaCreacion; }
            set
            {
                if (_vent_dFechaCreacion != value)
                {
                    _vent_dFechaCreacion = value;
                    OnPropertyChanged("vent_dFechaCreacion");
                }
            }
        }
        private System.DateTime _vent_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> vent_sUsuarioModificacion
        {
            get { return _vent_sUsuarioModificacion; }
            set
            {
                if (_vent_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("vent_sUsuarioModificacion", _vent_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _vent_sUsuarioModificacion = value;
                    OnPropertyChanged("vent_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _vent_sUsuarioModificacion;
    
        [DataMember]
        public string vent_vIPModificacion
        {
            get { return _vent_vIPModificacion; }
            set
            {
                if (_vent_vIPModificacion != value)
                {
                    _vent_vIPModificacion = value;
                    OnPropertyChanged("vent_vIPModificacion");
                }
            }
        }
        private string _vent_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> vent_dFechaModificacion
        {
            get { return _vent_dFechaModificacion; }
            set
            {
                if (_vent_dFechaModificacion != value)
                {
                    _vent_dFechaModificacion = value;
                    OnPropertyChanged("vent_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _vent_dFechaModificacion;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<CL_TICKET> CL_TICKET
        {
            get
            {
                if (_cL_TICKET == null)
                {
                    _cL_TICKET = new TrackableCollection<CL_TICKET>();
                    _cL_TICKET.CollectionChanged += FixupCL_TICKET;
                }
                return _cL_TICKET;
            }
            set
            {
                if (!ReferenceEquals(_cL_TICKET, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_cL_TICKET != null)
                    {
                        _cL_TICKET.CollectionChanged -= FixupCL_TICKET;
                    }
                    _cL_TICKET = value;
                    if (_cL_TICKET != null)
                    {
                        _cL_TICKET.CollectionChanged += FixupCL_TICKET;
                    }
                    OnNavigationPropertyChanged("CL_TICKET");
                }
            }
        }
        private TrackableCollection<CL_TICKET> _cL_TICKET;
    
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
        public SI_OFICINACONSULAR SI_OFICINACONSULAR
        {
            get { return _sI_OFICINACONSULAR; }
            set
            {
                if (!ReferenceEquals(_sI_OFICINACONSULAR, value))
                {
                    var previousValue = _sI_OFICINACONSULAR;
                    _sI_OFICINACONSULAR = value;
                    FixupSI_OFICINACONSULAR(previousValue);
                    OnNavigationPropertyChanged("SI_OFICINACONSULAR");
                }
            }
        }
        private SI_OFICINACONSULAR _sI_OFICINACONSULAR;

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
            CL_TICKET.Clear();
            SE_USUARIO = null;
            SE_USUARIO1 = null;
            SI_PARAMETRO = null;
            SI_OFICINACONSULAR = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.CL_VENTANILLA.Contains(this))
            {
                previousValue.CL_VENTANILLA.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.CL_VENTANILLA.Contains(this))
                {
                    SE_USUARIO.CL_VENTANILLA.Add(this);
                }
    
                vent_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.CL_VENTANILLA1.Contains(this))
            {
                previousValue.CL_VENTANILLA1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.CL_VENTANILLA1.Contains(this))
                {
                    SE_USUARIO1.CL_VENTANILLA1.Add(this);
                }
    
                vent_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                vent_sUsuarioModificacion = null;
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
    
            if (previousValue != null && previousValue.CL_VENTANILLA.Contains(this))
            {
                previousValue.CL_VENTANILLA.Remove(this);
            }
    
            if (SI_PARAMETRO != null)
            {
                if (!SI_PARAMETRO.CL_VENTANILLA.Contains(this))
                {
                    SI_PARAMETRO.CL_VENTANILLA.Add(this);
                }
    
                vent_sSectorId = SI_PARAMETRO.para_sParametroId;
            }
            else if (!skipKeys)
            {
                vent_sSectorId = null;
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
    
        private void FixupSI_OFICINACONSULAR(SI_OFICINACONSULAR previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.CL_VENTANILLA.Contains(this))
            {
                previousValue.CL_VENTANILLA.Remove(this);
            }
    
            if (SI_OFICINACONSULAR != null)
            {
                if (!SI_OFICINACONSULAR.CL_VENTANILLA.Contains(this))
                {
                    SI_OFICINACONSULAR.CL_VENTANILLA.Add(this);
                }
    
                vent_sOficinaConsularId = SI_OFICINACONSULAR.ofco_sOficinaConsularId;
            }
            else if (!skipKeys)
            {
                vent_sOficinaConsularId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SI_OFICINACONSULAR")
                    && (ChangeTracker.OriginalValues["SI_OFICINACONSULAR"] == SI_OFICINACONSULAR))
                {
                    ChangeTracker.OriginalValues.Remove("SI_OFICINACONSULAR");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SI_OFICINACONSULAR", previousValue);
                }
                if (SI_OFICINACONSULAR != null && !SI_OFICINACONSULAR.ChangeTracker.ChangeTrackingEnabled)
                {
                    SI_OFICINACONSULAR.StartTracking();
                }
            }
        }
    
        private void FixupCL_TICKET(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (CL_TICKET item in e.NewItems)
                {
                    item.CL_VENTANILLA = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("CL_TICKET", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CL_TICKET item in e.OldItems)
                {
                    if (ReferenceEquals(item.CL_VENTANILLA, this))
                    {
                        item.CL_VENTANILLA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("CL_TICKET", item);
                    }
                }
            }
        }

        #endregion
    }
}