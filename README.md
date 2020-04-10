# AJAX TagHelper For ASP.NET Core MVC
Add ajax option to Anchor TagHelper in asp.net core 

in this sample I add these features to Anchor TagHelper for ASP.NET Core MVC
asp-ajax
asp-ajax-loading
asp-ajax-method
asp-ajax-mode
asp-ajax-update
asp-ajax-onBegin
asp-ajax-onComplete

after this change, you can use Anchor Tagler Like this :
```c#
 <a asp-action="create" asp-controller="sitemenu" asp-area="admin"
                        asp-ajax="true"
                        asp-ajax-method="get" 
                        asp-ajax-mode="replace"
                        asp-ajax-loading="ajaxloading"
                        asp-ajax-update="modalContent"
                        asp-ajax-onBegin="showModal()"
                        asp-ajax-onComplete=""
                        class="btn btn-success btn-icon-split">
                        <span class="icon text-white-50"><i class="fas fa-plus"></i></span>
                        <span class="text"> Add Menu </span>
  </a>
```  
also I add two additional options for adding these features with initial default values, 
that means
We use this taghelper repeatedly in real projects, and at this point we usually use the same values for these options
with these two additional options, those same values are easily added, 
I rewrote the example above using this option:
```c#
<a asp-action="create" asp-controller="sitemenu" asp-area="admin"
                        asp-ajax-default-values="true"
                        asp-ajax-default-functions="true"
                        class="btn btn-success btn-icon-split">
                        <span class="icon text-white-50"><i class="fas fa-plus"></i></span>
                        <span class="text"> Add Menu </span>
</a>
