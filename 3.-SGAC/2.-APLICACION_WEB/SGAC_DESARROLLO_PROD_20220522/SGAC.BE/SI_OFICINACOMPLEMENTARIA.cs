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
    [KnownType(typeof(RE_ACTOMIGRATORIOFORMATO))]
    [KnownType(typeof(SE_USUARIO))]
    [KnownType(typeof(SI_PARAMETRO))]
    public partial class SI_OFICINACOMPLEMENTARIA: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public short ofcm_sOficinaComplementariaId
        {
            get { return _ofcm_sOficinaComplementariaId; }
            set
            {
                if (_ofcm_sOficinaComplementariaId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ofcm_sOficinaComplementariaId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _ofcm_sOficinaComplementariaId = value;
                    OnPropertyChanged("ofcm_sOficinaComplementariaId");
                }
            }
        }
        private short _ofcm_sOficinaComplementariaId;
    
        [DataMember]
        public short ofcm_sTipoId
        {
            get { return _ofcm_sTipoId; }
            set
            {
                if (_ofcm_sTipoId != value)
                {
                    ChangeTracker.RecordOriginalValue("ofcm_sTipoId", _ofcm_sTipoId);
                    if (!IsDeserializing)
                    {
                        if (SI_PARAMETRO != null && SI_PARAMETRO.para_sParametroId != value)
                        {
                            SI_PARAMETRO = null;
                        }
                    }
                    _ofcm_sTipoId = value;
                    OnPropertyChanged("ofcm_sTipoId");
                }
            }
        }
        private short _ofcm_sTipoId;
    
        [DataMember]
        public string ofcm_vCodigo
        {
            get { return _ofcm_vCodigo; }
            set
            {
                if (_ofcm_vCodigo != value)
                {
                    _ofcm_vCodigo = value;
                    OnPropertyChanged("ofcm_vCodigo");
                }
            }
        }
        private string _ofcm_vCodigo;
    
        [DataMember]
        public string ofcm_vNombre
        {
            get { return _ofcm_vNombre; }
            set
            {
                if (_ofcm_vNombre != value)
                {
                    _ofcm_vNombre = value;
                    OnPropertyChanged("ofcm_vNombre");
                }
            }
        }
        private string _ofcm_vNombre;
    
        [DataMember]
        public string ofcm_cEstado
        {
            get { return _ofcm_cEstado; }
            set
            {
                if (_ofcm_cEstado != value)
                {
                    _ofcm_cEstado = value;
                    OnPropertyChanged("ofcm_cEstado");
                }
            }
        }
        private string _ofcm_cEstado;
    
        [DataMember]
        public short ofcm_sUsuarioCreacion
        {
            get { return _ofcm_sUsuarioCreacion; }
            set
            {
                if (_ofcm_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("ofcm_sUsuarioCreacion", _ofcm_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _ofcm_sUsuarioCreacion = value;
                    OnPropertyChanged("ofcm_sUsuarioCreacion");
                }
            }
        }
        private short _ofcm_sUsuarioCreacion;
    
        [DataMember]
        public string ofcm_vIPCreacion
        {
            get { return _ofcm_vIPCreacion; }
            set
            {
                if (_ofcm_vIPCreacion != value)
                {
                    _ofcm_vIPCreacion = value;
                    OnPropertyChanged("ofcm_vIPCreacion");
                }
            }
        }
        private string _ofcm_vIPCreacion;
    
        [DataMember]
        public System.DateTime ofcm_dFechaCreacion
        {
            get { return _ofcm_dFechaCreacion; }
            set
            {
                if (_ofcm_dFechaCreacion != value)
                {
                    _ofcm_dFechaCreacion = value;
                    OnPropertyChanged("ofcm_dFechaCreacion");
                }
            }
        }
        private System.DateTime _ofcm_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> ofcm_sUsuarioModificacion
        {
            get { return _ofcm_sUsuarioModificacion; }
            set
            {
                if (_ofcm_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("ofcm_sUsuarioModificacion", _ofcm_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _ofcm_sUsuarioModificacion = value;
                    OnPropertyChanged("ofcm_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _ofcm_sUsuarioModificacion;
    
        [DataMember]
        public string ofcm_vIPModificacion
        {
            get { return _ofcm_vIPModificacion; }
            set
            {
                if (_ofcm_vIPModificacion != value)
                {
                    _ofcm_vIPModificacion = value;
                    OnPropertyChanged("ofcm_vIPModificacion");
                }
            }
        }
        private string _ofcm_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> ofcm_dFechaModificacion
        {
            get { return _ofcm_dFechaModificacion; }
            set
            {
                if (_ofcm_dFechaModificacion != value)
                {
                    _ofcm_dFechaModificacion = value;
                    OnPropertyChanged("ofcm_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _ofcm_dFechaModificacion;

        #endregion
        #region Navigation Properties
    
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
            RE_ACTOMIGRATORIOFORMATO.Clear();
            SE_USUARIO = null;
            SE_USUARIO1 = null;
            SI_PARAMETRO = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SI_OFICINACOMPLEMENTARIA.Contains(this))
            {
                previousValue.SI_OFICINACOMPLEMENTARIA.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.SI_OFICINACOMPLEMENTARIA.Contains(this))
                {
                    SE_USUARIO.SI_OFICINACOMPLEMENTARIA.Add(this);
                }
    
                ofcm_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.SI_OFICINACOMPLEMENTARIA1.Contains(this))
            {
                previousValue.SI_OFICINACOMPLEMENTARIA1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.SI_OFICINACOMPLEMENTARIA1.Contains(this))
                {
                    SE_USUARIO1.SI_OFICINACOMPLEMENTARIA1.Add(this);
                }
    
                ofcm_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                ofcm_sUsuarioModificacion = null;
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
    
            if (previousValue != null && previousValue.SI_OFICINACOMPLEMENTARIA.Contains(this))
            {
                previousValue.SI_OFICINACOMPLEMENTARIA.Remove(this);
            }
    
            if (SI_PARAMETRO != null)
            {
                if (!SI_PARAMETRO.SI_OFICINACOMPLEMENTARIA.Contains(this))
                {
                    SI_PARAMETRO.SI_OFICINACOMPLEMENTARIA.Add(this);
                }
    
                ofcm_sTipoId = SI_PARAMETRO.para_sParametroId;
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
                    item.SI_OFICINACOMPLEMENTARIA = this;
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
                    if (ReferenceEquals(item.SI_OFICINACOMPLEMENTARIA, this))
                    {
                        item.SI_OFICINACOMPLEMENTARIA = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("RE_ACTOMIGRATORIOFORMATO", item);
                    }
                }
            }
        }

        #endregion
    }
}
