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
    [KnownType(typeof(SI_OFICINACONSULAR))]
    public partial class CL_TICKETERA: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public short tira_sTicketeraId
        {
            get { return _tira_sTicketeraId; }
            set
            {
                if (_tira_sTicketeraId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'tira_sTicketeraId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _tira_sTicketeraId = value;
                    OnPropertyChanged("tira_sTicketeraId");
                }
            }
        }
        private short _tira_sTicketeraId;
    
        [DataMember]
        public short tira_sOficinaConsularId
        {
            get { return _tira_sOficinaConsularId; }
            set
            {
                if (_tira_sOficinaConsularId != value)
                {
                    ChangeTracker.RecordOriginalValue("tira_sOficinaConsularId", _tira_sOficinaConsularId);
                    if (!IsDeserializing)
                    {
                        if (SI_OFICINACONSULAR != null && SI_OFICINACONSULAR.ofco_sOficinaConsularId != value)
                        {
                            SI_OFICINACONSULAR = null;
                        }
                    }
                    _tira_sOficinaConsularId = value;
                    OnPropertyChanged("tira_sOficinaConsularId");
                }
            }
        }
        private short _tira_sOficinaConsularId;
    
        [DataMember]
        public string tira_vNombre
        {
            get { return _tira_vNombre; }
            set
            {
                if (_tira_vNombre != value)
                {
                    _tira_vNombre = value;
                    OnPropertyChanged("tira_vNombre");
                }
            }
        }
        private string _tira_vNombre;
    
        [DataMember]
        public string tira_vMarca
        {
            get { return _tira_vMarca; }
            set
            {
                if (_tira_vMarca != value)
                {
                    _tira_vMarca = value;
                    OnPropertyChanged("tira_vMarca");
                }
            }
        }
        private string _tira_vMarca;
    
        [DataMember]
        public string tira_vModelo
        {
            get { return _tira_vModelo; }
            set
            {
                if (_tira_vModelo != value)
                {
                    _tira_vModelo = value;
                    OnPropertyChanged("tira_vModelo");
                }
            }
        }
        private string _tira_vModelo;
    
        [DataMember]
        public string tira_vSerie
        {
            get { return _tira_vSerie; }
            set
            {
                if (_tira_vSerie != value)
                {
                    _tira_vSerie = value;
                    OnPropertyChanged("tira_vSerie");
                }
            }
        }
        private string _tira_vSerie;
    
        [DataMember]
        public string tira_vCaracteristicas
        {
            get { return _tira_vCaracteristicas; }
            set
            {
                if (_tira_vCaracteristicas != value)
                {
                    _tira_vCaracteristicas = value;
                    OnPropertyChanged("tira_vCaracteristicas");
                }
            }
        }
        private string _tira_vCaracteristicas;
    
        [DataMember]
        public string tira_cEstado
        {
            get { return _tira_cEstado; }
            set
            {
                if (_tira_cEstado != value)
                {
                    _tira_cEstado = value;
                    OnPropertyChanged("tira_cEstado");
                }
            }
        }
        private string _tira_cEstado;
    
        [DataMember]
        public short tira_sUsuarioCreacion
        {
            get { return _tira_sUsuarioCreacion; }
            set
            {
                if (_tira_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("tira_sUsuarioCreacion", _tira_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _tira_sUsuarioCreacion = value;
                    OnPropertyChanged("tira_sUsuarioCreacion");
                }
            }
        }
        private short _tira_sUsuarioCreacion;
    
        [DataMember]
        public string tira_vIPCreacion
        {
            get { return _tira_vIPCreacion; }
            set
            {
                if (_tira_vIPCreacion != value)
                {
                    _tira_vIPCreacion = value;
                    OnPropertyChanged("tira_vIPCreacion");
                }
            }
        }
        private string _tira_vIPCreacion;
    
        [DataMember]
        public System.DateTime tira_dFechaCreacion
        {
            get { return _tira_dFechaCreacion; }
            set
            {
                if (_tira_dFechaCreacion != value)
                {
                    _tira_dFechaCreacion = value;
                    OnPropertyChanged("tira_dFechaCreacion");
                }
            }
        }
        private System.DateTime _tira_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> tira_sUsuarioModificacion
        {
            get { return _tira_sUsuarioModificacion; }
            set
            {
                if (_tira_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("tira_sUsuarioModificacion", _tira_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _tira_sUsuarioModificacion = value;
                    OnPropertyChanged("tira_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _tira_sUsuarioModificacion;
    
        [DataMember]
        public string tira_vIPModificacion
        {
            get { return _tira_vIPModificacion; }
            set
            {
                if (_tira_vIPModificacion != value)
                {
                    _tira_vIPModificacion = value;
                    OnPropertyChanged("tira_vIPModificacion");
                }
            }
        }
        private string _tira_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> tira_dFechaModificacion
        {
            get { return _tira_dFechaModificacion; }
            set
            {
                if (_tira_dFechaModificacion != value)
                {
                    _tira_dFechaModificacion = value;
                    OnPropertyChanged("tira_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _tira_dFechaModificacion;

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
    
            if (previousValue != null && previousValue.CL_TICKETERA.Contains(this))
            {
                previousValue.CL_TICKETERA.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.CL_TICKETERA.Contains(this))
                {
                    SE_USUARIO.CL_TICKETERA.Add(this);
                }
    
                tira_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.CL_TICKETERA1.Contains(this))
            {
                previousValue.CL_TICKETERA1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.CL_TICKETERA1.Contains(this))
                {
                    SE_USUARIO1.CL_TICKETERA1.Add(this);
                }
    
                tira_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                tira_sUsuarioModificacion = null;
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
    
        private void FixupSI_OFICINACONSULAR(SI_OFICINACONSULAR previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.CL_TICKETERA.Contains(this))
            {
                previousValue.CL_TICKETERA.Remove(this);
            }
    
            if (SI_OFICINACONSULAR != null)
            {
                if (!SI_OFICINACONSULAR.CL_TICKETERA.Contains(this))
                {
                    SI_OFICINACONSULAR.CL_TICKETERA.Add(this);
                }
    
                tira_sOficinaConsularId = SI_OFICINACONSULAR.ofco_sOficinaConsularId;
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
                    item.CL_TICKETERA = this;
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
                    if (ReferenceEquals(item.CL_TICKETERA, this))
                    {
                        item.CL_TICKETERA = null;
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
