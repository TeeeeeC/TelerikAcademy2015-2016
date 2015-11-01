function solve() {
  return function () {
    /* globals $ */
      $.fn.gallery = function (columns) {
          columns = columns || 4;

          var $gallery = $(this);
          $gallery.addClass('gallery');

          var $selected = $gallery.children().last();
          var $currSelectedImage = $selected.find('#current-image');
          var $prevSelectedImage = $selected.find('#previous-image');
          var $nextSelectedImage = $selected.find('#next-image');
          $selected.hide();

          var $galleryList = $gallery.children('.gallery-list');

          var $imageContainer = $gallery.find('.image-container');
          $imageContainer.each(function (index, element) {
              if (index % columns === 0) {
                  $(element).addClass('clearfix');
              }
          });

          $imageContainer.on('click', 'img', function () {
              var $currImage = this;
              var $lastImg = $galleryList.find('img').last();
              var $firstImg = $galleryList.find('img').first();
              var $srcCurrImage = $($currImage).attr('src');
              var $srcPrevImage = $($currImage).parent().prev().children().attr('src');
              var $srcNextImage = $($currImage).parent().next().children().attr('src');
              var $indexCurrImage = $($currImage).attr('data-info');
              var $indexPrevImage = (+$indexCurrImage - 1);
              var $indexNextImage = (+$indexCurrImage + 1);

              if ($indexPrevImage == (+$firstImg.attr('data-info')) - 1) {
                  $indexPrevImage = $lastImg.attr('data-info');
                  $srcPrevImage = $lastImg.attr('src');
              }

              if ($indexNextImage == (+$lastImg.attr('data-info')) + 1) {
                  $indexNextImage = $firstImg.attr('data-info');
                  $srcNextImage = $firstImg.attr('src');
              }

              $galleryList.addClass('blurred');
              $('<div />').appendTo($gallery).addClass('disabled-background');
              $selected.show();

              $currSelectedImage.attr('src', $srcCurrImage);
              $currSelectedImage.attr('data-info', $indexCurrImage);

              $prevSelectedImage.attr('src', $srcPrevImage);
              $prevSelectedImage.attr('data-info', $indexPrevImage);

              $nextSelectedImage.attr('src', $srcNextImage);
              $nextSelectedImage.attr('data-info', $indexNextImage);
          });

          $currSelectedImage.on('click', function () {
              var $currImage = this;
              if ($($currImage).attr('data-info') === $($currSelectedImage).attr('data-info')) {
                  $selected.hide();
                  $galleryList.removeClass('blurred');
                  $gallery.find('.disabled-background').remove();
              }
          });

          $prevSelectedImage.on('click', function () {
              var $this = $(this);
              var $currImage = $galleryList.find('img[src="' + $this.attr('src') + '"]');
              var $lastImg = $galleryList.find('img').last();
              var $firstImg = $galleryList.find('img').first();
              var $srcCurrImage = $($currImage).attr('src');
              var $srcPrevImage = $($currImage).parent().prev().children().attr('src');
              var $srcNextImage = $($currImage).parent().next().children().attr('src');
              var $indexCurrImage = $($currImage).attr('data-info');
              var $indexPrevImage = (+$indexCurrImage - 1);
              var $indexNextImage = (+$indexCurrImage + 1);

              if ($indexPrevImage == (+$firstImg.attr('data-info')) - 1) {
                  $indexPrevImage = $lastImg.attr('data-info');
                  $srcPrevImage = $lastImg.attr('src');
              }

              if ($indexNextImage == (+$lastImg.attr('data-info')) + 1) {
                  $indexNextImage = $firstImg.attr('data-info');
                  $srcNextImage = $firstImg.attr('src');
              }

              $galleryList.addClass('blurred');
              $('<div />').appendTo($gallery).addClass('disabled-background');
              $selected.show();

              $currSelectedImage.attr('src', $srcCurrImage);
              $currSelectedImage.attr('data-info', $indexCurrImage);

              $prevSelectedImage.attr('src', $srcPrevImage);
              $prevSelectedImage.attr('data-info', $indexPrevImage);

              $nextSelectedImage.attr('src', $srcNextImage);
              $nextSelectedImage.attr('data-info', $indexNextImage);
          });

          $nextSelectedImage.on('click', function () {
              var $this = $(this);
              var $currImage = $galleryList.find('img[src="' + $this.attr('src') + '"]');
              var $lastImg = $galleryList.find('img').last();
              var $firstImg = $galleryList.find('img').first();
              var $srcCurrImage = $($currImage).attr('src');
              var $srcPrevImage = $($currImage).parent().prev().children().attr('src');
              var $srcNextImage = $($currImage).parent().next().children().attr('src');
              var $indexCurrImage = $($currImage).attr('data-info');
              var $indexPrevImage = (+$indexCurrImage - 1);
              var $indexNextImage = (+$indexCurrImage + 1);

              if ($indexPrevImage == (+$firstImg.attr('data-info')) - 1) {
                  $indexPrevImage = $lastImg.attr('data-info');
                  $srcPrevImage = $lastImg.attr('src');
              }

              if ($indexNextImage == (+$lastImg.attr('data-info')) + 1) {
                  $indexNextImage = $firstImg.attr('data-info');
                  $srcNextImage = $firstImg.attr('src');
              }

              $galleryList.addClass('blurred');
              $('<div />').appendTo($gallery).addClass('disabled-background');
              $selected.show();

              $currSelectedImage.attr('src', $srcCurrImage);
              $currSelectedImage.attr('data-info', $indexCurrImage);

              $prevSelectedImage.attr('src', $srcPrevImage);
              $prevSelectedImage.attr('data-info', $indexPrevImage);

              $nextSelectedImage.attr('src', $srcNextImage);
              $nextSelectedImage.attr('data-info', $indexNextImage);
          });
    };
  };
}

module.exports = solve;