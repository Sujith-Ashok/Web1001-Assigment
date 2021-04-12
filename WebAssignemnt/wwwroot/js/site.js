// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
if ('caches' in window) {
    const offcache = 'cache Offline';
    let buttonOff = $("#OffBtn");

    let checkCache = (url, cacheChange = true) => {
        caches.open(offcache).then((cache) => {
            cache.match(url).then((response) => {
                let match = ('object' == typeof response);
                if (match) {
                    if (cacheChange)
                        cache.delete(window.location.href);

                    if (cacheChange) {
                        buttonOff.val('Save cache');
                        buttonOff.attr('aria-label', 'Save cache');
                    } else {
                        buttonOff.val('Delete cache');
                    }

                } else {
                    if (cacheChange)
                        cache.add(window.location.href);

                    if (cacheChange) {
                        buttonOff.val('Delete cache');
                    } else {
                        buttonOff.val('Save cache');
                        buttonOff.attr('aria-label', 'Save cache');
                    }
                }
            });
        });
    }

    buttonOff.on("click", () => {
        checkCache(window.location.href);
    });

    checkCache(window.location.href, false);

    buttonOff.removeAttr('hidden');
}