(function ($) {
    "use strict";
    var fullHeight = function () {
        $('.js-fullheight').css('height', $(window).height());
        $(window).resize(function () {
            $('.js-fullheight').css('height', $(window).height());
        });
    };
    fullHeight();
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });



    DecoupledDocumentEditor
        .create(document.querySelector('#editor'), {
            mediaEmbed: {
                previewsInData: true,
            },
            toolbar: {
                items: [
                    'heading', '|', 'fontSize', 'fontFamily', '|', 'bold', 'italic', 'underline', 'strikethrough', 'highlight', '|', 'alignment',
                    '|', 'numberedList', 'bulletedList', '|', 'indent', 'outdent',
                    '|', 'todoList', 'link', 'blockQuote', 'imageUpload', 'insertTable', 'mediaEmbed', '|', 'undo', 'redo', '|', 'codeBlock']
            },
            image: {
                toolbar: [
                    'imageTextAlternative', 'imageStyle:full', 'imageStyle:side'
                ]
            },
            table: {
                contentToolbar: [
                    'tableColumn', 'tableRow', 'mergeTableCells'
                ]
            },
        })
        .then(editor => {
            window.editor = editor;
            document.querySelector('.document-editor__toolbar').appendChild(editor.ui.view.toolbar.element);
            document.querySelector('.ck-toolbar').classList.add('ck-reset_all');
        })
        .catch(error => {
        });



}
)(jQuery);


function InsertHTML(data) {
    const viewFragment = editor.data.processor.toView(data);
    const modelFragment = editor.data.toModel(viewFragment);
    editor.model.insertContent(modelFragment);
}


function Create() {
    var article = new Object();
    article.Title = $("#Title").val();
    article.Description = $("#Description").val();
    article.Content = editor.getData();
    article.Thumb = $("#Thumb").val();
    $.ajax({
        type: "POST",
        url: "/cp/article/Create",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(article),
        success: function (result) {
            if (result == "Saved!")
                document.location = "/cp";
        }
    })
}

function Update() {
    var article = new Object();
    article.Id = $("#Id").val();
    article.Title = $("#Title").val();
    article.Description = $("#Description").val();
    article.Content = editor.getData();
    article.Thumb = $("#Thumb").val();
    $.ajax({
        type: "PUT",
        url: "/cp/article/update",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(article),
        success: function (result) {
            if (result == "Ok!")
                document.location = "/cp";
        }
    })
}

function CheckImage() {
    var urlImage = $("#Thumb").val();
    $("#previewImageThumb").html(`<img src="${urlImage}" />`);
}

function Edit(id) {
    document.location = `/cp/article/edit?id=${id}`;
}

function SaveImageCkEditor(e) {
    var urlAvatar = $("#AvatarCkeditor").val();
    var img = '<img src="' + urlAvatar + '" />&nbsp;';
    InsertHTML(img);
    $('modal').show('hide');
}