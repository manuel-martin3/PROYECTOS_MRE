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
    [KnownType(typeof(RE_EMPRESA))]
    [KnownType(typeof(SE_USUARIO))]
    [KnownType(typeof(RE_RESIDENCIA))]
    public partial class RE_EMPRESARESIDENCIA: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public long emre_iEmpresaId
        {
            get { return _emre_iEmpresaId; }
            set
            {
                if (_emre_iEmpresaId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'emre_iEmpresaId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    if (!IsDeserializing)
                    {
                        if (RE_EMPRESA != null && RE_EMPRESA.empr_iEmpresaId != value)
                        {
                            RE_EMPRESA = null;
                        }
                    }
                    _emre_iEmpresaId = value;
                    OnPropertyChanged("emre_iEmpresaId");
                }
            }
        }
        private long _emre_iEmpresaId;
    
        [DataMember]
        public long emre_iResidenciaId
        {
            get { return _emre_iResidenciaId; }
            set
            {
                if (_emre_iResidenciaId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'emre_iResidenciaId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    if (!IsDeserializing)
                    {
                        if (RE_RESIDENCIA != null && RE_RESIDENCIA.resi_iResidenciaId != value)
                        {
                            RE_RESIDENCIA = null;
                        }
                    }
                    _emre_iResidenciaId = value;
                    OnPropertyChanged("emre_iResidenciaId");
                }
            }
        }
        private long _emre_iResidenciaId;
    
        [DataMember]
        public string emre_cEstado
        {
            get { return _emre_cEstado; }
            set
            {
                if (_emre_cEstado != value)
                {
                    _emre_cEstado = value;
                    OnPropertyChanged("emre_cEstado");
                }
            }
        }
        private string _emre_cEstado;
    
        [DataMember]
        public short emre_sUsuarioCreacion
        {
            get { return _emre_sUsuarioCreacion; }
            set
            {
                if (_emre_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("emre_sUsuarioCreacion", _emre_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _emre_sUsuarioCreacion = value;
                    OnPropertyChanged("emre_sUsuarioCreacion");
                }
            }
        }
        private short _emre_sUsuarioCreacion;
    
        [DataMember]
        public string emre_vIPCreacion
        {
            get { return _emre_vIPCreacion; }
            set
            {
                if (_emre_vIPCreacion != value)
                {
                    _emre_vIPCreacion = value;
                    OnPropertyChanged("emre_vIPCreacion");
                }
            }
        }
        private string _emre_vIPCreacion;
    
        [DataMember]
        public System.DateTime emre_dFechaCreacion
        {
            get { return _emre_dFechaCreacion; }
            set
            {
                if (_emre_dFechaCreacion != value)
                {
                    _emre_dFechaCreacion = value;
                    OnPropertyChanged("emre_dFechaCreacion");
                }
            }
        }
        private System.DateTime _emre_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> emre_sUsuarioModificacion
        {
            get { return _emre_sUsuarioModificacion; }
            set
            {
                if (_emre_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("emre_sUsuarioModificacion", _emre_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _emre_sUsuarioModificacion = value;
                    OnPropertyChanged("emre_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _emre_sUsuarioModificacion;
    
        [DataMember]
        public string emre_vIPModificacion
        {
            get { return _emre_vIPModificacion; }
            set
            {
                if (_emre_vIPModificacion != value)
                {
                    _emre_vIPModificacion = value;
                    OnPropertyChanged("emre_vIPModificacion");
                }
            }
        }
        private string _emre_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> emre_dFechaModificacion
        {
            get { return _emre_dFechaModificacion; }
            set
            {
                if (_emre_dFechaModificacion != value)
                {
                    _emre_dFechaModificacion = value;
                    OnPropertyChanged("emre_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _emre_dFechaModificacion;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public RE_EMPRESA RE_EMPRESA
        {
            get { return _rE_EMPRESA; }
            set
            {
                if (!ReferenceEquals(_rE_EMPRESA, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // This the dependent end of an identifying relationship, so the principal end cannot be changed if it is already set,
                        // otherwise it can only be set to an entity with a primary key that is the same value as the dependent's foreign key.
                        if (emre_iEmpresaId != value.empr_iEmpresaId)
                        {
                            throw new InvalidOperationException("The principal end of an identifying relationship can only be changed when the dependent end is in the Added state.");
                        }
                    }
                    var previousValue = _rE_EMPRESA;
                    _rE_EMPRESA = value;
                    FixupRE_EMPRESA(previousValue);
                    OnNavigationPropertyChanged("RE_EMPRESA");
                }
            }
        }
        private RE_EMPRESA _rE_EMPRESA;
    
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
        public RE_RESIDENCIA RE_RESIDENCIA
        {
            get { return _rE_RESIDENCIA; }
            set
            {
                if (!ReferenceEquals(_rE_RESIDENCIA, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // This the dependent end of an identifying relationship, so the principal end cannot be changed if it is already set,
                        // otherwise it can only be set to an entity with a primary key that is the same value as the dependent's foreign key.
                        if (emre_iResidenciaId != value.resi_iResidenciaId)
                        {
                            throw new InvalidOperationException("The principal end of an identifying relationship can only be changed when the dependent end is in the Added state.");
                        }
                    }
                    var previousValue = _rE_RESIDENCIA;
                    _rE_RESIDENCIA = value;
                    FixupRE_RESIDENCIA(previousValue);
                    OnNavigationPropertyChanged("RE_RESIDENCIA");
                }
            }
        }
        private RE_RESIDENCIA _rE_RESIDENCIA;

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
    
        // This entity type is the dependent end in at least one association that performs cascade deletes.
        // This event handler will process notifications that occur when the principal end is deleted.
        internal void HandleCascadeDelete(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                this.MarkAsDeleted();
            }
        }
    
        protected virtual void ClearNavigationProperties()
        {
            RE_EMPRESA = null;
            SE_USUARIO = null;
            SE_USUARIO1 = null;
            RE_RESIDENCIA = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupRE_EMPRESA(RE_EMPRESA previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_EMPRESARESIDENCIA.Contains(this))
            {
                previousValue.RE_EMPRESARESIDENCIA.Remove(this);
            }
    
            if (RE_EMPRESA != null)
            {
                if (!RE_EMPRESA.RE_EMPRESARESIDENCIA.Contains(this))
                {
                    RE_EMPRESA.RE_EMPRESARESIDENCIA.Add(this);
                }
    
                emre_iEmpresaId = RE_EMPRESA.empr_iEmpresaId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("RE_EMPRESA")
                    && (ChangeTracker.OriginalValues["RE_EMPRESA"] == RE_EMPRESA))
                {
                    ChangeTracker.OriginalValues.Remove("RE_EMPRESA");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("RE_EMPRESA", previousValue);
                }
                if (RE_EMPRESA != null && !RE_EMPRESA.ChangeTracker.ChangeTrackingEnabled)
                {
                    RE_EMPRESA.StartTracking();
                }
            }
        }
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_EMPRESARESIDENCIA.Contains(this))
            {
                previousValue.RE_EMPRESARESIDENCIA.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.RE_EMPRESARESIDENCIA.Contains(this))
                {
                    SE_USUARIO.RE_EMPRESARESIDENCIA.Add(this);
                }
    
                emre_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.RE_EMPRESARESIDENCIA1.Contains(this))
            {
                previousValue.RE_EMPRESARESIDENCIA1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.RE_EMPRESARESIDENCIA1.Contains(this))
                {
                    SE_USUARIO1.RE_EMPRESARESIDENCIA1.Add(this);
                }
    
                emre_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                emre_sUsuarioModificacion = null;
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
    
        private void FixupRE_RESIDENCIA(RE_RESIDENCIA previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.RE_EMPRESARESIDENCIA.Contains(this))
            {
                previousValue.RE_EMPRESARESIDENCIA.Remove(this);
            }
    
            if (RE_RESIDENCIA != null)
            {
                if (!RE_RESIDENCIA.RE_EMPRESARESIDENCIA.Contains(this))
                {
                    RE_RESIDENCIA.RE_EMPRESARESIDENCIA.Add(this);
                }
    
                emre_iResidenciaId = RE_RESIDENCIA.resi_iResidenciaId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("RE_RESIDENCIA")
                    && (ChangeTracker.OriginalValues["RE_RESIDENCIA"] == RE_RESIDENCIA))
                {
                    ChangeTracker.OriginalValues.Remove("RE_RESIDENCIA");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("RE_RESIDENCIA", previousValue);
                }
                if (RE_RESIDENCIA != null && !RE_RESIDENCIA.ChangeTracker.ChangeTrackingEnabled)
                {
                    RE_RESIDENCIA.StartTracking();
                }
            }
        }

        #endregion
    }
}
