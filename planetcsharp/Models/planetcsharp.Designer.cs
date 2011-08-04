﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("planetcsharpModel", "FK_Post_Blog", "Blogs", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(planetcsharp.Models.Blog), "Posts", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(planetcsharp.Models.Post), true)]

#endregion

namespace planetcsharp.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class planetcsharpEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new planetcsharpEntities object using the connection string found in the 'planetcsharpEntities' section of the application configuration file.
        /// </summary>
        public planetcsharpEntities() : base("name=planetcsharpEntities", "planetcsharpEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new planetcsharpEntities object.
        /// </summary>
        public planetcsharpEntities(string connectionString) : base(connectionString, "planetcsharpEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new planetcsharpEntities object.
        /// </summary>
        public planetcsharpEntities(EntityConnection connection) : base(connection, "planetcsharpEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Blog> Blogs
        {
            get
            {
                if ((_Blogs == null))
                {
                    _Blogs = base.CreateObjectSet<Blog>("Blogs");
                }
                return _Blogs;
            }
        }
        private ObjectSet<Blog> _Blogs;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Post> Posts
        {
            get
            {
                if ((_Posts == null))
                {
                    _Posts = base.CreateObjectSet<Post>("Posts");
                }
                return _Posts;
            }
        }
        private ObjectSet<Post> _Posts;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Blogs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBlogs(Blog blog)
        {
            base.AddObject("Blogs", blog);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Posts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPosts(Post post)
        {
            base.AddObject("Posts", post);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="planetcsharpModel", Name="Blog")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Blog : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Blog object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="feedUrl">Initial value of the FeedUrl property.</param>
        /// <param name="blogUrl">Initial value of the BlogUrl property.</param>
        public static Blog CreateBlog(global::System.Int32 id, global::System.String name, global::System.String feedUrl, global::System.String blogUrl)
        {
            Blog blog = new Blog();
            blog.ID = id;
            blog.Name = name;
            blog.FeedUrl = feedUrl;
            blog.BlogUrl = blogUrl;
            return blog;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FeedUrl
        {
            get
            {
                return _FeedUrl;
            }
            set
            {
                OnFeedUrlChanging(value);
                ReportPropertyChanging("FeedUrl");
                _FeedUrl = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FeedUrl");
                OnFeedUrlChanged();
            }
        }
        private global::System.String _FeedUrl;
        partial void OnFeedUrlChanging(global::System.String value);
        partial void OnFeedUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BlogUrl
        {
            get
            {
                return _BlogUrl;
            }
            set
            {
                OnBlogUrlChanging(value);
                ReportPropertyChanging("BlogUrl");
                _BlogUrl = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("BlogUrl");
                OnBlogUrlChanged();
            }
        }
        private global::System.String _BlogUrl;
        partial void OnBlogUrlChanging(global::System.String value);
        partial void OnBlogUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> LastUpdated
        {
            get
            {
                return _LastUpdated;
            }
            set
            {
                OnLastUpdatedChanging(value);
                ReportPropertyChanging("LastUpdated");
                _LastUpdated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastUpdated");
                OnLastUpdatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _LastUpdated;
        partial void OnLastUpdatedChanging(Nullable<global::System.DateTime> value);
        partial void OnLastUpdatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String OwnerEmail
        {
            get
            {
                return _OwnerEmail;
            }
            set
            {
                OnOwnerEmailChanging(value);
                ReportPropertyChanging("OwnerEmail");
                _OwnerEmail = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("OwnerEmail");
                OnOwnerEmailChanged();
            }
        }
        private global::System.String _OwnerEmail;
        partial void OnOwnerEmailChanging(global::System.String value);
        partial void OnOwnerEmailChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("planetcsharpModel", "FK_Post_Blog", "Posts")]
        public EntityCollection<Post> Posts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Post>("planetcsharpModel.FK_Post_Blog", "Posts");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Post>("planetcsharpModel.FK_Post_Blog", "Posts", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="planetcsharpModel", Name="Post")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Post : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Post object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="url">Initial value of the Url property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="blogID">Initial value of the BlogID property.</param>
        /// <param name="createdAt">Initial value of the CreatedAt property.</param>
        public static Post CreatePost(global::System.Int32 id, global::System.String url, global::System.String title, global::System.Int32 blogID, global::System.DateTime createdAt)
        {
            Post post = new Post();
            post.ID = id;
            post.Url = url;
            post.Title = title;
            post.BlogID = blogID;
            post.CreatedAt = createdAt;
            return post;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Url
        {
            get
            {
                return _Url;
            }
            set
            {
                OnUrlChanging(value);
                ReportPropertyChanging("Url");
                _Url = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Url");
                OnUrlChanged();
            }
        }
        private global::System.String _Url;
        partial void OnUrlChanging(global::System.String value);
        partial void OnUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Content
        {
            get
            {
                return _Content;
            }
            set
            {
                OnContentChanging(value);
                ReportPropertyChanging("Content");
                _Content = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Content");
                OnContentChanged();
            }
        }
        private global::System.String _Content;
        partial void OnContentChanging(global::System.String value);
        partial void OnContentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BlogID
        {
            get
            {
                return _BlogID;
            }
            set
            {
                OnBlogIDChanging(value);
                ReportPropertyChanging("BlogID");
                _BlogID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BlogID");
                OnBlogIDChanged();
            }
        }
        private global::System.Int32 _BlogID;
        partial void OnBlogIDChanging(global::System.Int32 value);
        partial void OnBlogIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> PostedDate
        {
            get
            {
                return _PostedDate;
            }
            set
            {
                OnPostedDateChanging(value);
                ReportPropertyChanging("PostedDate");
                _PostedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PostedDate");
                OnPostedDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _PostedDate;
        partial void OnPostedDateChanging(Nullable<global::System.DateTime> value);
        partial void OnPostedDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreatedAt
        {
            get
            {
                return _CreatedAt;
            }
            set
            {
                OnCreatedAtChanging(value);
                ReportPropertyChanging("CreatedAt");
                _CreatedAt = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreatedAt");
                OnCreatedAtChanged();
            }
        }
        private global::System.DateTime _CreatedAt;
        partial void OnCreatedAtChanging(global::System.DateTime value);
        partial void OnCreatedAtChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("planetcsharpModel", "FK_Post_Blog", "Blogs")]
        public Blog Blog
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Blog>("planetcsharpModel.FK_Post_Blog", "Blogs").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Blog>("planetcsharpModel.FK_Post_Blog", "Blogs").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Blog> BlogReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Blog>("planetcsharpModel.FK_Post_Blog", "Blogs");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Blog>("planetcsharpModel.FK_Post_Blog", "Blogs", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
