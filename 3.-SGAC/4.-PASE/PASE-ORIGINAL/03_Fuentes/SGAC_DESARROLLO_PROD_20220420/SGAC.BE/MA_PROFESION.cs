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
    [KnownType(typeof(RE_PERSONA))]
    public partial class MA_PROFESION: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public short prof_sProfesionId
        {
            get { return _prof_sProfesionId; }
            set
            {
                if (_prof_sProfesionId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'prof_sProfesionId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _prof_sProfesionId = value;
                    OnPropertyChanged("prof_sProfesionId");
                }
            }
        }
        private short _prof_sProfesionId;
    
        [DataMember]
        public string prof_vCodigo
        {
            get { return _prof_vCodigo; }
            set
            {
                if (_prof_vCodigo != value)
                {
                    _prof_vCodigo = value;
                    OnPropertyChanged("prof_vCodigo");
                }
            }
        }
        private string _prof_vCodigo;
    
        [DataMember]
        public string prof_vDescripcionCorta
        {
            get { return _prof_vDescripcionCorta; }
            set
            {
                if (_prof_vDescripcionCorta != value)
                {
                    _prof_vDescripcionCorta = value;
                    OnPropertyChanged("prof_vDescripcionCorta");
                }
            }
        }
        private string _prof_vDescripcionCorta;
    
        [DataMember]
        public string prof_vDescripcionLarga
        {
            get { return _prof_vDescripcionLarga; }
            set
            {
                if (_prof_vDescripcionLarga != value)
                {
                    _prof_vDescripcionLarga = value;
                    OnPropertyChanged("prof_vDescripcionLarga");
                }
            }
        }
        private string _prof_vDescripcionLarga;
    
        [DataMember]
        public string prof_cEstado
        {
            get { return _prof_cEstado; }
            set
            {
                if (_prof_cEstado != value)
                {
                    _prof_cEstado = value;
                    OnPropertyChanged("prof_cEstado");
                }
            }
        }
        private string _prof_cEstado;
    
        [DataMember]
        public short prof_sUsuarioCreacion
        {
            get { return _prof_sUsuarioCreacion; }
            set
            {
                if (_prof_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("prof_sUsuarioCreacion", _prof_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _prof_sUsuarioCreacion = value;
                    OnPropertyChanged("prof_sUsuarioCreacion");
                }
            }
        }
        private short _prof_sUsuarioCreacion;
    
        [DataMember]
        public string prof_vIPCreacion
        {
            get { return _prof_vIPCreacion; }
            set
            {
                if (_prof_vIPCreacion != value)
                {
                    _prof_vIPCreacion = value;
                    OnPropertyChanged("prof_vIPCreacion");
                }
            }
        }
        private string _prof_vIPCreacion;
    
        [DataMember]
        public System.DateTime prof_dFechaCreacion
        {
            get { return _prof_dFechaCreacion; }
            set
            {
                if (_prof_dFechaCreacion != value)
                {
                    _prof_dFechaCreacion = value;
                    OnPropertyChanged("prof_dFechaCreacion");
                }
            }
        }
        private System.DateTime _prof_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> prof_sUsuarioModificacion
        {
            get { return _prof_sUsuarioModificacion; }
            set
            {
                if (_prof_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("prof_sUsuarioModificacion", _prof_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _prof_sUsuarioModificacion = value;
                    OnPropertyChanged("prof_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _prof_sUsuarioModificacion;
    
        [DataMember]
        public string prof_vIPModificacion
        {
            get { return _prof_vIPModificacion; }
            set
            {
                if (_prof_vIPModificacion != value)
                {
                    _prof_vIPModificacion = value;
                    OnPropertyChanged("prof_vIPModificacion");
                }
            }
        }
        private string _prof_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> prof_dFechaModificacion
        {
            get { return _prof_dFechaModificacion; }
            set
            {
                if (_prof_dFechaModificacion != value)
                {
                    _prof_dFechaModificacion = value;
                    OnPropertyChanged("prof_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _prof_dFechaModificacion;

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
        public TrackableCollection<RE_PERSONA> RE_PERSONA
        {
            get
            {
                if (_rE_PERSONA == null)
                {
                    _rE_PERSONA = new TrackableCollection<RE_PERSONA>();
                    _rE_PERSONA.CollectionChanged += FixupRE_PERSONA;
                }
                return _rE_PERSONA;
            }
            set
            {
                if (!ReferenceEquals(_rE_PERSONA, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_rE_PERSONA != null)
                    {
                        _rE_PERSONA.CollectionChanged -= FixupRE_PERSONA;
                    }
                    _rE_PERSONA = value;
                    if (_rE_PERSONA != null)
                    {
                        _rE_PERSONA.CollectionChanged += FixupRE_PERSONA;
                    }
                    OnNavigationPropertyChanged("RE_PERSONA");
                }
            }
        }
        private TrackableCollection<RE_PERSONA> _rE_PERSONA;

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
            RE_PERSONA.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.MA_PROFESION.Contains(this))
            {
                previousValue.MA_PROFESION.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.MA_PROFESION.Contains(this))
                {
                    SE_USUARIO.MA_PROFESION.Add(this);
                }
    
                prof_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.MA_PROFESION1.Contains(this))
            {
                previousValue.MA_PROFESION1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.MA_PROFESION1.Contains(this))
                {
                    SE_USUARIO1.MA_PROFESION1.Add(this);
                }
    
                prof_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                prof_sUsuarioModificacion = null;
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
    
        private void FixupRE_PERSONA(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (RE_PERSONA item in e.NewItems)
                {
                    item.MA_PROFESION = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("RE_PERSONA", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (RE_PERSONA item in e.OldItems)
                {
                    if (ReferenceEquals(item.MA_PROFESION, this))
                    {
                        item.MA_PROFESION = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("RE_PERSONA", item);
                    }
                }
            }
        }

        #endregion
    }
}
