var CACHE_NAME = 'Sujith web application cache';
var urlsToCache = [
    '/'
];

self.addEventListener('install', function (event) {
    console.info('Service worker Installed');

    event.waitUntil(
        caches.open(CACHE_NAME)
            .then(function (cache) {
                console.log('Opened cache');
                return cache.addAll(urlsToCache);
            })
    );

    console.info('the page is being cached');
});


self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request)
            .then(function (response) {
                // Cache hit - return response
                if (response) {
                    return response;
                }
                return fetch(event.request);
            }
            )
    );
});