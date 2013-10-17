HTTP/1.0 200 OK
Date: Fri, 11 Oct 2013 17:47:51 GMT
Server: gwiseguy/2.0
Cache-Control: no-cache
Content-Type: text/html; charset=utf-8
P3P: CP="This is not a P3P policy! See http://support.google.com/accounts/bin/answer.py?answer=151657&hl=en-US for more info."
X-Content-Type-Options: nosniff
X-XSS-Protection: 1; mode=block; report=https://www.google.com/appserve/security-bugs/log/youtube
X-Frame-Options: SAMEORIGIN
Set-Cookie: VISITOR_INFO1_LIVE=NT10YQrB344; path=/; domain=.youtube.com; expires=Thu, 12-Jun-2014 05:40:51 GMT
Set-Cookie: YSC=PDN9t4nbYdM; path=/; domain=.youtube.com; httponly
Set-Cookie: PREF=f1=40000000; path=/; domain=.youtube.com; expires=Thu, 12-Jun-2014 05:40:51 GMT
Expires: Tue, 27 Apr 1971 19:44:06 EST
Alternate-Protocol: 80:quic

  <!DOCTYPE html><html lang="en" data-cast-api-enabled="true"><head><script>var ytcsi = {gt: function(n) {n = (n || '') + 'data_';return ytcsi[n] || (ytcsi[n] = {tick: {},span: {},info: {}});},tick: function(l, t, n) {ytcsi.gt(n).tick[l] = t || +new Date();},span: function(l, s, n) {ytcsi.gt(n).span[l] = (typeof s == 'number') ? s :+new Date() - ytcsi.data_.tick[l];},info: function(k, v, n) {ytcsi.gt(n).info[k] = v;}};(function() {var perf = window['performance'] || window['mozPerformance'] ||window['msPerformance'] || window['webkitPerformance'];ytcsi.tick('_start', perf ? perf['timing']['responseStart'] : null);})();if (document.webkitVisibilityState == 'prerender') {ytcsi.info('prerender', 1);document.addEventListener('webkitvisibilitychange', function() {ytcsi.tick('_start');}, false);}try {ytcsi.pt_ = (window.chrome && chrome.csi().pageT ||window.gtbExternal && gtbExternal.pageT() ||window.external && external.pageT);if (ytcsi.pt_) {ytcsi.info('pt', Math.floor(ytcsi.pt_));}} catch(e) {}</script>  
  <link id="css-1406971372" class="www-core" rel="stylesheet" href="http://s.ytimg.com/yts/cssbin/www-core-vflf5GlIu.css" data-loaded="true">
<script>if (window.ytcsi) {window.ytcsi.tick("ce", null, '');}</script>  

  <title>YouTube</title><link rel="search" type="application/opensearchdescription+xml" href="http://www.youtube.com/opensearch?locale=en_US" title="YouTube Video Search"><link rel="shortcut icon" href="http://s.ytimg.com/yts/img/favicon-vfldLzJxy.ico" type="image/x-icon">     <link rel="icon" href="//s.ytimg.com/yts/img/favicon_32-vflWoMFGx.png" sizes="32x32"><link rel="alternate" media="handheld" href="http://m.youtube.com/index?&amp;desktop_uri=%2F"><link rel="alternate" media="only screen and (max-width: 640px)" href="http://m.youtube.com/index?&amp;desktop_uri=%2F"><meta name="description" content="Share your videos with friends, family, and the world"><meta name="keywords" content="video, sharing, camera phone, video phone, free, upload">  <meta property="og:image" content="//s.ytimg.com/yts/img/youtube_logo_stacked-vfl225ZTx.png">
  <meta property="fb:app_id" content="87741124305">
  <link rel="publisher" href="https://plus.google.com/115229808208707341778">
    <link id="css-601750674" class="www-home-c4" rel="stylesheet" href="http://s.ytimg.com/yts/cssbin/www-home-c4-vfl3fjhMT.css" data-loaded="true">

<script>if (window.ytcsi) {window.ytcsi.tick("cl", null, '');}</script></head><!-- machid: oYUswT1NnZ2dWcWpSY2laTERqQkRHbHhuWGRVWmtmMHFFdVo0amx6MlhlcVBYSWJ6V1hHNURR -->
    <body dir="ltr" class="  ltr        site-left-aligned  hitchhiker-enabled      guide-enabled    guide-expanded
  " id="body">

  <div id="body-container"><form name="logoutForm" method="POST" action="/logout"><input type="hidden" name="action_logout" value="1"></form>    
    
    <div id="yt-masthead-container" class="yt-grid-box yt-base-gutter" ><div id="yt-masthead" class="">    <a id="logo-container" href="/" title="YouTube home" class=" "><img id="logo" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="YouTube home"><span class="content-region">CA</span></a>
<div id="yt-masthead-signin"><button class=" yt-uix-button yt-uix-button-primary yt-uix-button-size-default" type="button" onclick=";window.location.href=this.getAttribute(&#39;href&#39;);return false;" href="https://accounts.google.com/ServiceLogin?uilel=3&amp;service=youtube&amp;hl=en&amp;passive=true&amp;continue=http%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26app%3Ddesktop%26feature%3Dsign_in_button%26hl%3Den%26next%3D%252F"  role="button"><span class="yt-uix-button-content">Sign in </span></button></div><div id="yt-masthead-content"><span id="masthead-upload-button-group"><a href="//www.youtube.com/upload" class="yt-uix-button   yt-uix-sessionlink yt-uix-button-default yt-uix-button-size-default" data-sessionlink="feature=mhsb&amp;ei=xzlYUsTgGamP8gH_q4GACg"><span class="yt-uix-button-content">Upload </span></a></span><form id="masthead-search" class="search-form consolidated-form" action="/results" onsubmit="if (_gel(&#39;masthead-search-term&#39;).value == &#39;&#39;) return false;"><button onclick="if (_gel(&#39;masthead-search-term&#39;).value == &#39;&#39;) return false; _gel(&#39;masthead-search&#39;).submit(); return false;;return true;" id="search-btn" type="submit" tabindex="2" dir="ltr" class="search-btn-component search-button yt-uix-button yt-uix-button-default yt-uix-button-size-default"  role="button"><span class="yt-uix-button-content">Search </span></button><div id="masthead-search-terms" class="masthead-search-terms-border" dir="ltr"><label><input id="masthead-search-term" autocomplete="off" autofocus class="search-term yt-uix-form-input-bidi" name="search_query" value="" type="text" tabindex="1" title="Search"></label><script>var searchBox = document.getElementById('masthead-search-term');if (searchBox) {searchBox.focus();}</script></div></form></div></div></div>
    
  <div id="alerts">
      

  </div>
  <div id="header">
        <div id="masthead_child_div"></div>


  </div>
<div id="page-container"><div id="page" class="  home  clearfix"><div id="guide" >        <div id="guide-container"
      class=" vve-check"
      data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CAEQ_h4">
      <div id="guide-main" class="    guide-module     spf-nolink   yt-uix-tdl ">
        <div class="guide-module-toggle">
          <span class="guide-module-toggle-icon">
            <span class="guide-module-toggle-arrow"></span>
            <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="">
            <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" id="collapsed-notification-icon">
          </span>
          <div class="guide-module-toggle-label">
            <h3>
              <span>
Guide
              </span>
            </h3>
          </div>
        </div>
          <div class="guide-module-content yt-scrollbar">
    <ul class="guide-toplevel">
            <li class="guide-section vve-check"
    data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CAIQ5isoAA">
    <div class="guide-item-container personal-item">
      <ul class="guide-user-links yt-box">
            <li class="vve-check guide-channel" id="HCtnHdj3df7iM-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/HCtnHdj3df7iM"
    title="Popular on YouTube"
    data-sessionlink="feature=g-channel&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="HCtnHdj3df7iM"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//i1.ytimg.com/li/tnHdj3df7iM/default.jpg" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>Popular on YouTube</span>
      </span>
    </span>

  </a>

  </li>

            <li class="vve-check guide-channel" id="HCp-Rdqh3z4Uc-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/HCp-Rdqh3z4Uc"
    title="Music"
    data-sessionlink="feature=g-channel&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="HCp-Rdqh3z4Uc"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//i1.ytimg.com/li/p-Rdqh3z4Uc/default.jpg" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>Music</span>
      </span>
    </span>

  </a>

  </li>

            <li class="vve-check guide-channel" id="HC7Dr1BKwqctY-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/HC7Dr1BKwqctY"
    title="Sports"
    data-sessionlink="feature=g-channel&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="HC7Dr1BKwqctY"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//i1.ytimg.com/li/7Dr1BKwqctY/default.jpg" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>Sports</span>
      </span>
    </span>

  </a>

  </li>

            <li class="vve-check guide-channel" id="HChfZhJdhTqX8-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/HChfZhJdhTqX8"
    title="Gaming"
    data-sessionlink="feature=g-channel&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="HChfZhJdhTqX8"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//i1.ytimg.com/li/hfZhJdhTqX8/default.jpg" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>Gaming</span>
      </span>
    </span>

  </a>

  </li>

            <li class="vve-check guide-channel" id="HC-r1FlvvNFs0-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/HC-r1FlvvNFs0"
    title="Education"
    data-sessionlink="feature=g-channel&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="HC-r1FlvvNFs0"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//i1.ytimg.com/li/-r1FlvvNFs0/default.jpg" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>Education</span>
      </span>
    </span>

  </a>

  </li>

            <li class="vve-check guide-channel" id="UCYbn7i88VIwuGq_sQRKN4DQ-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/UCYbn7i88VIwuGq_sQRKN4DQ"
    title="Movies"
    data-sessionlink="feature=g-channel&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="UCYbn7i88VIwuGq_sQRKN4DQ"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="https://lh6.googleusercontent.com/-K2w3xFmUKng/AAAAAAAAAAI/AAAAAAAAAAA/nVxw6Kh_kZQ/s88-c-k/photo.jpg" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>Movies</span>
      </span>
    </span>

  </a>

  </li>

      </ul>
    </div>
    <hr class="guide-section-separator">
  </li>

            <li class="guide-section vve-check"
    data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CAkQ5isoAQ">
    <div class="guide-item-container personal-item">
        <h3>Channels for you</h3>
      <ul class="guide-user-links yt-box">
            <li class="vve-check guide-channel" id="UCGjylN-4QCpn8XJ1uY-UOgA-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/UCGjylN-4QCpn8XJ1uY-UOgA"
    title="danisnotonfire"
    data-sessionlink="feature=g-chfeat&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="UCGjylN-4QCpn8XJ1uY-UOgA"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//i1.ytimg.com/i/GjylN-4QCpn8XJ1uY-UOgA/1.jpg" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>danisnotonfire</span>
      </span>
    </span>

  </a>

  </li>

            <li class="vve-check guide-channel" id="UCkzRDjtq4ngMADh45j2KsJQ-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/UCkzRDjtq4ngMADh45j2KsJQ"
    title="MachinimaPrime&#39;s channel"
    data-sessionlink="feature=g-chfeat&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="UCkzRDjtq4ngMADh45j2KsJQ"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//i1.ytimg.com/i/kzRDjtq4ngMADh45j2KsJQ/1.jpg" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>MachinimaPrime&#39;s channel</span>
      </span>
    </span>

  </a>

  </li>

            <li class="vve-check guide-channel" id="UCCihVBb2gleWF4vZGZTXTSg-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/UCCihVBb2gleWF4vZGZTXTSg"
    title="TUF FSOne"
    data-sessionlink="feature=g-chfeat&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="UCCihVBb2gleWF4vZGZTXTSg"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//s.ytimg.com/yts/img/silhouette250-vflEqxKg9.png" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>TUF FSOne</span>
      </span>
    </span>

  </a>

  </li>

            <li class="vve-check guide-channel" id="UCujCZYL7mpAMHeBups0yTsA-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/UCujCZYL7mpAMHeBups0yTsA"
    title="Lives with Meredith Vieira"
    data-sessionlink="feature=g-chfeat&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="UCujCZYL7mpAMHeBups0yTsA"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//s.ytimg.com/yts/img/silhouette250-vflEqxKg9.png" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>Lives with Meredith Vieira</span>
      </span>
    </span>

  </a>

  </li>

            <li class="vve-check guide-channel" id="UCHX5-wIWTaClDu6uTKXKItg-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channel/UCHX5-wIWTaClDu6uTKXKItg"
    title="Truthloader"
    data-sessionlink="feature=g-chfeat&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="UCHX5-wIWTaClDu6uTKXKItg"
  >
    <span class="yt-valign-container">
        <span class="thumb">    <span class="video-thumb  yt-thumb yt-thumb-18"
      >
      <span class="yt-thumb-square">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-group-key="guide-channel-thumbs" src="//i1.ytimg.com/i/HX5-wIWTaClDu6uTKXKItg/1.jpg" data-thumb-manual="1" alt="Thumbnail" width="18" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
</span>
      <span class="display-name no-count">
        <span>Truthloader</span>
      </span>
    </span>

  </a>

  </li>

      </ul>
    </div>
    <hr class="guide-section-separator">
  </li>

            <li class="guide-section vve-check"
    data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CA8Q5isoAg">
    <div class="guide-item-container personal-item">
      <ul class="guide-user-links yt-box">
            <li class="vve-check guide-channel" id="guide_builder-guide-item">
        <a class="guide-item yt-uix-sessionlink yt-valign spf-nolink "
    href="/channels"
    title="Browse channels"
    data-sessionlink="feature=g-manage&amp;ei=xzlYUsTgGamP8gH_q4GACg"
    data-channel-id="guide_builder"
  >
    <span class="yt-valign-container">
        <span class="thumb guide-management-plus-icon">
          <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="">
        </span>
      <span class="display-name no-count">
        <span>Browse channels</span>
      </span>
    </span>

  </a>

  </li>

      </ul>
    </div>
    <hr class="guide-section-separator">
  </li>

            <li class="guide-section guide-header signup-promo guided-help-box">
    <p>
      Sign in now to see your channels and recommendations!
    </p>
    <div id="guide-builder-promo-buttons" class="signed-out clearfix">
      <a href="https://accounts.google.com/ServiceLogin?uilel=3&amp;service=youtube&amp;hl=en&amp;passive=true&amp;continue=http%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26app%3Ddesktop%26feature%3Dsign_in_promo%26hl%3Den%26next%3D%252F" class="yt-uix-button   yt-uix-sessionlink yt-uix-button-primary yt-uix-button-size-default" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg"><span class="yt-uix-button-content">Sign In </span></a>
    </div>
  </li>

    </ul>
  </div>

      </div>
        <div id="watch-context-container" class="guide-module collapsed hid"></div>

    </div>

</div><div id="player" class="  off-screen  ">
  <div id="playlist" class="playlist">
    
  </div>

  <div id="player-unavailable" class="  hid  ">
    
  </div>

    <div id="player-api" class="player-width player-height off-screen-target watch-content player-api"></div>


    <script>if (window.ytcsi) {window.ytcsi.tick("bf", null, '');}</script>
    <script>var ytplayer = ytplayer || {};ytplayer.config = {"attrs": {"id": "movie_player"}, "params": {"allowscriptaccess": "always", "bgcolor": "#000000", "allowfullscreen": "true"}, "sts": 15986, "url": "http:\/\/s.ytimg.com\/yts\/swfbin\/watch_as3-vflXQT03Y.swf", "assets": {"js": "http:\/\/s.ytimg.com\/yts\/jsbin\/html5player-vflO-N-9M.js", "css": "http:\/\/s.ytimg.com\/yts\/cssbin\/www-player-vflmk6z-0.css", "html": "\/html5_player_template"}, "html5": false, "url_v8": "http:\/\/s.ytimg.com\/yts\/swfbin\/cps-vfl5FBU76.swf", "url_v9as2": "http:\/\/s.ytimg.com\/yts\/swfbin\/cps-vfl5FBU76.swf", "args": {"enablejsapi": 1, "hl": "", "cr": "", "autoplay": "0", "fexp": "936100,924606,924616,924610,916914,925724,936401,906945,929935,929937,929939,939602,939604,906842,920605,912715,919811,935704,911504,934003,934004,931924,938608,913578,940501,934803,936308,935006,939201,900816,912711,934507,912714,907231,930635,936312,906001"}, "min_version": "8.0.0"};</script>

  <div id="playlist-tray" class="playlist-tray">
    
  </div>

  

  <div id="player-branded-banner" class="player-branded-banner">
    
  </div>
</div><div id="content" class="">  





  <div class="branded-page-v2-container  branded-page-v2-secondary-column-hidden" >
    <div class="branded-page-v2-col-container clearfix">
      <div class="branded-page-v2-primary-col">
            <div class="branded-page-v2-primary-col-header-container">
      
  <div id="context-source-container"data-context-source="Popular on YouTube"style="display:none;"></div>

    </div>
  <div class="branded-page-v2-body" id="gh-activityfeed">
        <div class="context-data-container">
          
          <div class="lohp-newspaper-shelf vve-check" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBMQ0R4oAA">
    
    <div class="lohp-large-shelf-container">
        <div class="context-data-item" data-context-item-type="video" data-context-item-views="2,474,271 views" data-context-item-title="Mean Tweets - Music Edition" data-context-item-time="3:01" data-context-item-user="Jimmy Kimmel Live" data-context-item-id="Zu5Oo23G67w" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBQQ0h4oAA">
    
    <a href="/watch?v=Zu5Oo23G67w" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink yt-fluid-thumb-link contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBQQ0h4oAA">    <span class="video-thumb  yt-thumb yt-thumb-370 yt-thumb-fluid"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img src="//i1.ytimg.com/vi/Zu5Oo23G67w/hqdefault.jpg" alt="Thumbnail" width="370" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">3:01</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="Zu5Oo23G67w" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
      <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBQQ0h4oAA"
     href="/watch?v=Zu5Oo23G67w"
     title="Mean Tweets - Music Edition">Mean Tweets - Music Edition</a>


      <div class="lohp-video-metadata">
          <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/JimmyKimmelLive" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UCa6vGFO9ty8v5KZJXQxdhaw" data-name="">Jimmy Kimmel Live</a>  <span class="yt-user-name-icon-verified">
    <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" class="yt-uix-tooltip yt-channel-title-icon-verified" alt="" title="Verified name">
  </span>

  </span>

          <span class="view-count">
      2,474,271 views
  </span>

            <span class="content-item-time-created" title="1 day ago">
      1 day ago
    </span>

      </div>
  </div>

    </div>
    <div class="lohp-medium-shelves-container">
            <div class="lohp-medium-shelf context-data-item vve-check " data-context-item-type="video" data-context-item-views="1,825,043 views" data-context-item-title="Archer -- Danger Zone" data-context-item-time="1:37" data-context-item-user="Archer" data-context-item-id="_7HkG6OSo3E" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBYQ0h4oAQ">
    
    <div class="lohp-media-object">
      <a href="/watch?v=_7HkG6OSo3E" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink yt-fluid-thumb-link contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBYQ0h4oAQ">    <span class="video-thumb  yt-thumb yt-thumb-170 yt-thumb-fluid"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img src="//i1.ytimg.com/vi/_7HkG6OSo3E/mqdefault.jpg" alt="Thumbnail" width="170" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">1:37</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="_7HkG6OSo3E" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
    </div>
    <div class="lohp-media-object-content lohp-medium-shelf-content">
        <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBYQ0h4oAQ"
     href="/watch?v=_7HkG6OSo3E"
     title="Archer -- Danger Zone">Archer -- Danger Zone</a>

      <div class="lohp-video-metadata attached">
          <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/FXArcher" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UCMMUVsoSPaiuFj0rMU1dX1A" data-name="">Archer</a>  <span class="yt-user-name-icon-verified">
    <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" class="yt-uix-tooltip yt-channel-title-icon-verified" alt="" title="Verified name">
  </span>

  </span>

      </div>
        <div class="lohp-video-metadata">
            <span class="view-count">
      1,825,043 views
  </span>

              <span class="content-item-time-created" title="1 day ago">
      1 day ago
    </span>

        </div>
    </div>
  </div>

            <div class="lohp-medium-shelf context-data-item vve-check " data-context-item-type="video" data-context-item-views="256,196 views" data-context-item-title="COP BREAKS WOMAN&#39;S FACE ON CAMERA IN CELL" data-context-item-time="9:52" data-context-item-user="sxephil" data-context-item-id="H_qsKEwxo5U" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBgQ0h4oAg">
    
    <div class="lohp-media-object">
      <a href="/watch?v=H_qsKEwxo5U" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink yt-fluid-thumb-link contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBgQ0h4oAg">    <span class="video-thumb  yt-thumb yt-thumb-170 yt-thumb-fluid"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img src="//i1.ytimg.com/vi/H_qsKEwxo5U/mqdefault.jpg" alt="Thumbnail" width="170" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">9:52</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="H_qsKEwxo5U" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
    </div>
    <div class="lohp-media-object-content lohp-medium-shelf-content">
        <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBgQ0h4oAg"
     href="/watch?v=H_qsKEwxo5U"
     title="COP BREAKS WOMAN&#39;S FACE ON CAMERA IN CELL">COP BREAKS WOMAN&#39;S FACE ON CAMERA IN CELL</a>

      <div class="lohp-video-metadata attached">
          <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/sxephil" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UClFSU9_bUb4Rc6OYfTt5SPw" data-name="">sxephil</a>
  </span>

      </div>
        <div class="lohp-video-metadata">
            <span class="view-count">
      256,196 views
  </span>

              <span class="content-item-time-created" title="20 hours ago">
      20 hours ago
    </span>

        </div>
    </div>
  </div>

            <div class="lohp-medium-shelf context-data-item vve-check " data-context-item-type="video" data-context-item-views="7,927,918 views" data-context-item-title="Eminem - Survival (Explicit)" data-context-item-time="4:32" data-context-item-user="EminemVEVO" data-context-item-id="NlmezywdxPI" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBoQ0h4oAw">
    
    <div class="lohp-media-object">
      <a href="/watch?v=NlmezywdxPI" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink yt-fluid-thumb-link contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBoQ0h4oAw">    <span class="video-thumb  yt-thumb yt-thumb-170 yt-thumb-fluid"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img src="//i1.ytimg.com/vi/NlmezywdxPI/mqdefault.jpg" alt="Thumbnail" width="170" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">4:32</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="NlmezywdxPI" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
    </div>
    <div class="lohp-media-object-content lohp-medium-shelf-content">
        <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBoQ0h4oAw"
     href="/watch?v=NlmezywdxPI"
     title="Eminem - Survival (Explicit)">Eminem - Survival (Explicit)</a>

      <div class="lohp-video-metadata attached">
          <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/EminemVEVO" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UC20vb-R_px4CguHzzBPhoyQ" data-name="">EminemVEVO</a>
  </span>

      </div>
        <div class="lohp-video-metadata">
            <span class="view-count">
      7,927,918 views
  </span>

              <span class="content-item-time-created" title="3 days ago">
      3 days ago
    </span>

        </div>
    </div>
  </div>

    </div>
  </div>



    
        <div class="lohp-vbox-list vve-check lohp-left-vbox-list"
    data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CBwQ1R4oAQ">
          <div class="vve-check" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CB0Qyx4oAA">
          <div class="lohp-shelf-cell-container lohp-category-shelf vve-check last-shelf-in-line" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CB4QzR4oAA">
    

    <div class="lohp-category-shelf-item-list lohp-shelf-size-3">
              <h2 class="branded-page-module-title">

      <a class="yt-uix-sessionlink branded-page-module-title-link spf-nolink" href="/channel/HCZDb06gtz6rQ" title="Most Popular" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CB8Qzh4">
        Most Popular
      </a>
        <a href="/watch_videos?feature=c4-overview&amp;type=0&amp;title=Most+Popular&amp;more_url=&amp;video_ids=VlOxlSOr3_M%2Cpa0tKmlH2Ks%2C2mjvfnUAfyo" class="yt-uix-button  shelves-play yt-uix-sessionlink yt-uix-button-default yt-uix-button-size-small" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg"><span class="yt-uix-button-icon-wrapper"><img class="yt-uix-button-icon yt-uix-button-icon-play-all" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></span><span class="yt-uix-button-content">Play </span></a>

  </h2>



        <div class="lohp-category-shelf-item context-data-item first-shelf-item " data-context-item-type="video" data-context-item-views="30,329,280 views" data-context-item-title="Telekinetic Coffee Shop Surprise" data-context-item-time="2:24" data-context-item-user="CarrieNYC" data-context-item-id="VlOxlSOr3_M">
          
          <a href="/watch?v=VlOxlSOr3_M" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCAQzx4oAA">    <span class="video-thumb  yt-thumb yt-thumb-189"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/VlOxlSOr3_M/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="189" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">2:24</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="VlOxlSOr3_M" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCAQzx4oAA"
     href="/watch?v=VlOxlSOr3_M"
     title="Telekinetic Coffee Shop Surprise">Telekinetic Coffee Shop Surprise</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      30,329,280 views
  </span>

                <span class="content-item-time-created" title="4 days ago">
      4 days ago
    </span>

          </div>
        </div>

        <div class="lohp-category-shelf-item context-data-item  " data-context-item-type="video" data-context-item-views="154,240 views" data-context-item-title="CHEST-BRAS 7 : LA CONFÉRENCE" data-context-item-time="1:14" data-context-item-user="CHESTBRAS" data-context-item-id="pa0tKmlH2Ks">
          
          <a href="/watch?v=pa0tKmlH2Ks" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCIQzx4oAQ">    <span class="video-thumb  yt-thumb yt-thumb-189"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/pa0tKmlH2Ks/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="189" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">1:14</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="pa0tKmlH2Ks" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCIQzx4oAQ"
     href="/watch?v=pa0tKmlH2Ks"
     title="CHEST-BRAS 7 : LA CONFÉRENCE">CHEST-BRAS 7 : LA CONFÉRENCE</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      154,240 views
  </span>

                <span class="content-item-time-created" title="1 day ago">
      1 day ago
    </span>

          </div>
        </div>

        <div class="lohp-category-shelf-item context-data-item  last-shelf-item " data-context-item-type="video" data-context-item-views="6,141,723 views" data-context-item-title="Jimmy Fallon, Miley Cyrus &amp; The Roots Sing &quot;We Can&#39;t Stop&quot; (A Cappella)" data-context-item-time="2:33" data-context-item-user="latenight" data-context-item-id="2mjvfnUAfyo">
          
          <a href="/watch?v=2mjvfnUAfyo" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCQQzx4oAg">    <span class="video-thumb  yt-thumb yt-thumb-189"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/2mjvfnUAfyo/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="189" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">2:33</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="2mjvfnUAfyo" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCQQzx4oAg"
     href="/watch?v=2mjvfnUAfyo"
     title="Jimmy Fallon, Miley Cyrus &amp; The Roots Sing &quot;We Can&#39;t Stop&quot; (A Cappella)">Jimmy Fallon, Miley Cyrus &amp; The Roots Sing &quot;We Can&#39;t Stop&quot; (A Cappella)</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      6,141,723 views
  </span>

                <span class="content-item-time-created" title="2 days ago">
      2 days ago
    </span>

          </div>
        </div>
    </div>
  </div>

  </div>

          <div class="vve-check" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCYQyx4oAQ">
          <div class="lohp-shelf-cell-container lohp-category-shelf vve-check " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCcQzR4oAA">
    

    <div class="lohp-category-shelf-item-list lohp-shelf-size-2">
              <h2 class="branded-page-module-title">

      <a class="yt-uix-sessionlink branded-page-module-title-link spf-nolink" href="/channel/HCp-Rdqh3z4Uc" title="Music" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCgQzh4">
        Music
      </a>
        <a href="/watch_videos?feature=c4-overview&amp;type=0&amp;title=Music&amp;more_url=&amp;video_ids=BpqNvskS_kM%2COxlJLz9M8hQ" class="yt-uix-button  shelves-play yt-uix-sessionlink yt-uix-button-default yt-uix-button-size-small" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg"><span class="yt-uix-button-icon-wrapper"><img class="yt-uix-button-icon yt-uix-button-icon-play-all" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></span><span class="yt-uix-button-content">Play </span></a>

  </h2>



        <div class="lohp-category-shelf-item context-data-item first-shelf-item " data-context-item-type="video" data-context-item-views="5,310,906 views" data-context-item-title="Hitler vs Vader 3. Epic Rap Battles of History Season 3." data-context-item-time="2:38" data-context-item-user="Epic Rap Battles of History" data-context-item-id="BpqNvskS_kM">
          
          <a href="/watch?v=BpqNvskS_kM" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCkQzx4oAA">    <span class="video-thumb  yt-thumb yt-thumb-182"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/BpqNvskS_kM/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="182" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">2:38</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="BpqNvskS_kM" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCkQzx4oAA"
     href="/watch?v=BpqNvskS_kM"
     title="Hitler vs Vader 3. Epic Rap Battles of History Season 3.">Hitler vs Vader 3. Epic Rap Battles of History Season 3.</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      5,310,906 views
  </span>

                <span class="content-item-time-created" title="4 days ago">
      4 days ago
    </span>

          </div>
        </div>

        <div class="lohp-category-shelf-item context-data-item  last-shelf-item " data-context-item-type="video" data-context-item-views="1,153,459 views" data-context-item-title="Tyler, The Creator - Tamale" data-context-item-time="4:32" data-context-item-user="OFWGKTA" data-context-item-id="OxlJLz9M8hQ">
          
          <a href="/watch?v=OxlJLz9M8hQ" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCsQzx4oAQ">    <span class="video-thumb  yt-thumb yt-thumb-182"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/OxlJLz9M8hQ/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="182" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">4:32</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="OxlJLz9M8hQ" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CCsQzx4oAQ"
     href="/watch?v=OxlJLz9M8hQ"
     title="Tyler, The Creator - Tamale">Tyler, The Creator - Tamale</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      1,153,459 views
  </span>

                <span class="content-item-time-created" title="3 days ago">
      3 days ago
    </span>

          </div>
        </div>
    </div>
  </div>

          <div class="lohp-shelf-cell-container lohp-category-shelf vve-check last-shelf-in-line" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CC0QzR4oAQ">
    

    <div class="lohp-category-shelf-item-list lohp-shelf-size-1">
              <h2 class="branded-page-module-title">

      <a class="yt-uix-sessionlink branded-page-module-title-link spf-nolink" href="/channel/HCexGj8bHSQek" title="Ray William Johnson" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CC4Qzh4">
        Ray William Johnson
      </a>
  </h2>



        <div class="lohp-category-shelf-item context-data-item first-shelf-item last-shelf-item " data-context-item-type="video" data-context-item-views="1,376,765 views" data-context-item-title="Hooking Up at a Party" data-context-item-time="4:45" data-context-item-user="RayWilliamJohnson" data-context-item-id="pPaxJmjYQKI">
          
          <a href="/watch?v=pPaxJmjYQKI" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CC8Qzx4oAA">    <span class="video-thumb  yt-thumb yt-thumb-165"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/pPaxJmjYQKI/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="165" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">4:45</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="pPaxJmjYQKI" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CC8Qzx4oAA"
     href="/watch?v=pPaxJmjYQKI"
     title="Hooking Up at a Party">Hooking Up at a Party</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      1,376,765 views
  </span>

                <span class="content-item-time-created" title="2 days ago">
      2 days ago
    </span>

          </div>
        </div>
    </div>
  </div>

  </div>

          <div class="vve-check" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDEQyx4oAg">
          <div class="lohp-shelf-cell-container lohp-category-shelf vve-check last-shelf-in-line" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDIQzR4oAA">
    

    <div class="lohp-category-shelf-item-list lohp-shelf-size-3">
              <h2 class="branded-page-module-title">

      <a class="yt-uix-sessionlink branded-page-module-title-link spf-nolink" href="/channel/HCxAJ-ON2kZuw" title="Entertainment" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDMQzh4">
        Entertainment
      </a>
        <a href="/watch_videos?feature=c4-overview&amp;type=0&amp;title=Entertainment&amp;more_url=&amp;video_ids=YCSP262sxBg%2CMUhHdTuU8UQ%2Ca1YF1LGSnNs" class="yt-uix-button  shelves-play yt-uix-sessionlink yt-uix-button-default yt-uix-button-size-small" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg"><span class="yt-uix-button-icon-wrapper"><img class="yt-uix-button-icon yt-uix-button-icon-play-all" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></span><span class="yt-uix-button-content">Play </span></a>

  </h2>



        <div class="lohp-category-shelf-item context-data-item first-shelf-item " data-context-item-type="video" data-context-item-views="166,423 views" data-context-item-title="#AKtv - Internet Police" data-context-item-time="8:16" data-context-item-user="AKakaAmazing" data-context-item-id="YCSP262sxBg">
          
          <a href="/watch?v=YCSP262sxBg" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDQQzx4oAA">    <span class="video-thumb  yt-thumb yt-thumb-189"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/YCSP262sxBg/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="189" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">8:16</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="YCSP262sxBg" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDQQzx4oAA"
     href="/watch?v=YCSP262sxBg"
     title="#AKtv - Internet Police">#AKtv - Internet Police</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      166,423 views
  </span>

                <span class="content-item-time-created" title="2 days ago">
      2 days ago
    </span>

          </div>
        </div>

        <div class="lohp-category-shelf-item context-data-item  " data-context-item-type="video" data-context-item-views="733,449 views" data-context-item-title="Scary Headless Man Prank" data-context-item-time="2:55" data-context-item-user="MagicofRahat" data-context-item-id="MUhHdTuU8UQ">
          
          <a href="/watch?v=MUhHdTuU8UQ" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDYQzx4oAQ">    <span class="video-thumb  yt-thumb yt-thumb-189"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/MUhHdTuU8UQ/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="189" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">2:55</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="MUhHdTuU8UQ" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDYQzx4oAQ"
     href="/watch?v=MUhHdTuU8UQ"
     title="Scary Headless Man Prank">Scary Headless Man Prank</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      733,449 views
  </span>

                <span class="content-item-time-created" title="3 days ago">
      3 days ago
    </span>

          </div>
        </div>

        <div class="lohp-category-shelf-item context-data-item  last-shelf-item " data-context-item-type="video" data-context-item-views="216,940 views" data-context-item-title="What You&#39;re REALLY Thinking During Yoga" data-context-item-time="1:32" data-context-item-user="BuzzFeedYellow" data-context-item-id="a1YF1LGSnNs">
          
          <a href="/watch?v=a1YF1LGSnNs" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDgQzx4oAg">    <span class="video-thumb  yt-thumb yt-thumb-189"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/a1YF1LGSnNs/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="189" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">1:32</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="a1YF1LGSnNs" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDgQzx4oAg"
     href="/watch?v=a1YF1LGSnNs"
     title="What You&#39;re REALLY Thinking During Yoga">What You&#39;re REALLY Thinking During Yoga</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      216,940 views
  </span>

                <span class="content-item-time-created" title="2 days ago">
      2 days ago
    </span>

          </div>
        </div>
    </div>
  </div>

  </div>

          <div class="vve-check" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDoQyx4oAw">
          <div class="lohp-shelf-cell-container lohp-category-shelf vve-check " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDsQzR4oAA">
    

    <div class="lohp-category-shelf-item-list lohp-shelf-size-1">
              <h2 class="branded-page-module-title">

      <a class="yt-uix-sessionlink branded-page-module-title-link spf-nolink" href="/user/ParisHiltonVEVO" title="Paris Hilton" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CDwQzh4">
        Paris Hilton
      </a>
  </h2>



        <div class="lohp-category-shelf-item context-data-item first-shelf-item last-shelf-item " data-context-item-type="video" data-context-item-views="1,942,571 views" data-context-item-title="Paris Hilton - Good Time (Explicit) ft. Lil Wayne" data-context-item-time="3:47" data-context-item-user="ParisHiltonVEVO" data-context-item-id="K1JMjwJG2UM">
          
          <a href="/watch?v=K1JMjwJG2UM" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CD0Qzx4oAA">    <span class="video-thumb  yt-thumb yt-thumb-165"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/K1JMjwJG2UM/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="165" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">3:47</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="K1JMjwJG2UM" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CD0Qzx4oAA"
     href="/watch?v=K1JMjwJG2UM"
     title="Paris Hilton - Good Time (Explicit) ft. Lil Wayne">Paris Hilton - Good Time (Explicit) ft. Lil Wayne</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      1,942,571 views
  </span>

                <span class="content-item-time-created" title="3 days ago">
      3 days ago
    </span>

          </div>
        </div>
    </div>
  </div>

          <div class="lohp-shelf-cell-container lohp-category-shelf vve-check " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CD8QzR4oAQ">
    

    <div class="lohp-category-shelf-item-list lohp-shelf-size-1">
              <h2 class="branded-page-module-title">

      <a class="yt-uix-sessionlink branded-page-module-title-link spf-nolink" href="/user/dodge" title="Dodge" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEAQzh4">
        Dodge
      </a>
  </h2>



        <div class="lohp-category-shelf-item context-data-item first-shelf-item last-shelf-item " data-context-item-type="video" data-context-item-views="488,132 views" data-context-item-title="Dodge Durango | Ron Burgundy | &quot;Ballroom Dancers&quot;" data-context-item-time="1:01" data-context-item-user="dodge" data-context-item-id="bsYSTPGDotY">
          
          <a href="/watch?v=bsYSTPGDotY" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEEQzx4oAA">    <span class="video-thumb  yt-thumb yt-thumb-165"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/bsYSTPGDotY/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="165" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">1:01</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="bsYSTPGDotY" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEEQzx4oAA"
     href="/watch?v=bsYSTPGDotY"
     title="Dodge Durango | Ron Burgundy | &quot;Ballroom Dancers&quot;">Dodge Durango | Ron Burgundy | &quot;Ballroom Dancers&quot;</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      488,132 views
  </span>

                <span class="content-item-time-created" title="3 days ago">
      3 days ago
    </span>

          </div>
        </div>
    </div>
  </div>

          <div class="lohp-shelf-cell-container lohp-category-shelf vve-check last-shelf-in-line" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEMQzR4oAg">
    

    <div class="lohp-category-shelf-item-list lohp-shelf-size-1">
              <h2 class="branded-page-module-title">

      <a class="yt-uix-sessionlink branded-page-module-title-link spf-nolink" href="/user/PhilipDeFranco" title="Philly D" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEQQzh4">
        Philly D
      </a>
  </h2>



        <div class="lohp-category-shelf-item context-data-item first-shelf-item last-shelf-item " data-context-item-type="video" data-context-item-views="990,054 views" data-context-item-title="I&#39;m Going to Be a Dad :)" data-context-item-time="3:22" data-context-item-user="Philly D" data-context-item-id="_ujk4SJVx8E">
          
          <a href="/watch?v=_ujk4SJVx8E" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEUQzx4oAA">    <span class="video-thumb  yt-thumb yt-thumb-165"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/_ujk4SJVx8E/mqdefault.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="165" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">3:22</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="_ujk4SJVx8E" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
            <a class="lohp-video-link max-line-2 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEUQzx4oAA"
     href="/watch?v=_ujk4SJVx8E"
     title="I&#39;m Going to Be a Dad :)">I&#39;m Going to Be a Dad :)</a>

          <div class="lohp-video-metadata">
              <span class="view-count">
      990,054 views
  </span>

                <span class="content-item-time-created" title="2 days ago">
      2 days ago
    </span>

          </div>
        </div>
    </div>
  </div>

  </div>

  </div>



    
        <div class="lohp-vbox-list vve-check lohp-right-vbox-list"
    data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEcQ1R4oAg">
        <div class="lohp-pyv-shelf-container" id="shelf-pyv-container">
    <iframe id="pyv-iframe" frameborder="0" scrolling="no" allowTransparency="true"></iframe>
  </div>

          <div class="lohp-vertical-shelf vve-check" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEgQzR4oAA">
    
            <h2 class="branded-page-module-title">

      <a class="yt-uix-sessionlink branded-page-module-title-link spf-nolink" href="/channel/HCp-Rdqh3z4Uc" title="Music" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEkQzh4">
        Music
      </a>
        <a href="/watch_videos?feature=c4-overview&amp;type=0&amp;title=Music&amp;more_url=&amp;video_ids=My2FRPA3Gf8%2CehcVomMexkY%2CnlcIKh6sBtc%2CCevxZvSJLk8" class="yt-uix-button  shelves-play yt-uix-sessionlink yt-uix-button-default yt-uix-button-size-small" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg"><span class="yt-uix-button-icon-wrapper"><img class="yt-uix-button-icon yt-uix-button-icon-play-all" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></span><span class="yt-uix-button-content">Play </span></a>

  </h2>


      <div class="lohp-vertical-shelf-item context-data-item" data-context-item-type="video" data-context-item-views="212,400,875 views" data-context-item-title="Miley Cyrus - Wrecking Ball" data-context-item-time="3:42" data-context-item-user="MileyCyrusVEVO" data-context-item-id="My2FRPA3Gf8">
        <div class="lohp-media-object ">
          <a href="/watch?v=My2FRPA3Gf8" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEoQzx4oAA">    <span class="video-thumb  yt-thumb yt-thumb-64"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/My2FRPA3Gf8/default.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="64" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">3:42</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="My2FRPA3Gf8" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
        </div>
        <div class="lohp-vertical-shelf-item-content lohp-media-object-content">
            <a class="lohp-video-link max-line-3 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEoQzx4oAA"
     href="/watch?v=My2FRPA3Gf8"
     title="Miley Cyrus - Wrecking Ball">Miley Cyrus - Wrecking Ball</a>

          <div class="lohp-video-metadata attached">
              <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/MileyCyrusVEVO" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UCdI8evszfZvyAl2UVCypkTA" data-name="">MileyCyrusVEVO</a>
  </span>

          </div>
        </div>
      </div>
      <div class="lohp-vertical-shelf-item context-data-item" data-context-item-type="video" data-context-item-views="42,638,554 views" data-context-item-title="Rihanna - Pour It Up (Explicit)" data-context-item-time="3:17" data-context-item-user="RihannaVEVO" data-context-item-id="ehcVomMexkY">
        <div class="lohp-media-object ">
          <a href="/watch?v=ehcVomMexkY" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEwQzx4oAQ">    <span class="video-thumb  yt-thumb yt-thumb-64"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/ehcVomMexkY/default.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="64" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">3:17</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="ehcVomMexkY" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
        </div>
        <div class="lohp-vertical-shelf-item-content lohp-media-object-content">
            <a class="lohp-video-link max-line-3 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CEwQzx4oAQ"
     href="/watch?v=ehcVomMexkY"
     title="Rihanna - Pour It Up (Explicit)">Rihanna - Pour It Up (Explicit)</a>

          <div class="lohp-video-metadata attached">
              <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/RihannaVEVO" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UC2xskkQVFEpLcGFnNSLQY0A" data-name="">RihannaVEVO</a>
  </span>

          </div>
        </div>
      </div>
      <div class="lohp-vertical-shelf-item context-data-item" data-context-item-type="video" data-context-item-views="30,244,202 views" data-context-item-title="Lorde - Royals (US Version)" data-context-item-time="3:21" data-context-item-user="LordeVEVO" data-context-item-id="nlcIKh6sBtc">
        <div class="lohp-media-object ">
          <a href="/watch?v=nlcIKh6sBtc" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CE4Qzx4oAg">    <span class="video-thumb  yt-thumb yt-thumb-64"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/nlcIKh6sBtc/default.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="64" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">3:21</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="nlcIKh6sBtc" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
        </div>
        <div class="lohp-vertical-shelf-item-content lohp-media-object-content">
            <a class="lohp-video-link max-line-3 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CE4Qzx4oAg"
     href="/watch?v=nlcIKh6sBtc"
     title="Lorde - Royals (US Version)">Lorde - Royals (US Version)</a>

          <div class="lohp-video-metadata attached">
              <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/LordeVEVO" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UCVrPiUtl29kULN2HIAm244Q" data-name="">LordeVEVO</a>
  </span>

          </div>
        </div>
      </div>
      <div class="lohp-vertical-shelf-item context-data-item" data-context-item-type="video" data-context-item-views="119,017,339 views" data-context-item-title="Katy Perry - Roar (Official)" data-context-item-time="4:30" data-context-item-user="KatyPerryVEVO" data-context-item-id="CevxZvSJLk8">
        <div class="lohp-media-object ">
          <a href="/watch?v=CevxZvSJLk8" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFAQzx4oAw">    <span class="video-thumb  yt-thumb yt-thumb-64"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/CevxZvSJLk8/default.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="64" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">4:30</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="CevxZvSJLk8" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
        </div>
        <div class="lohp-vertical-shelf-item-content lohp-media-object-content">
            <a class="lohp-video-link max-line-3 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFAQzx4oAw"
     href="/watch?v=CevxZvSJLk8"
     title="Katy Perry - Roar (Official)">Katy Perry - Roar (Official)</a>

          <div class="lohp-video-metadata attached">
              <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/KatyPerryVEVO" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UC-8Q-hLdECwQmaWNwXitYDw" data-name="">KatyPerryVEVO</a>
  </span>

          </div>
        </div>
      </div>
  </div>

          <div class="lohp-vertical-shelf vve-check" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFIQzR4oAQ">
    
            <h2 class="branded-page-module-title">

      <a class="yt-uix-sessionlink branded-page-module-title-link spf-nolink" href="/channel/HCZDb06gtz6rQ" title="Most Popular" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFMQzh4">
        Most Popular
      </a>
        <a href="/watch_videos?feature=c4-overview&amp;type=0&amp;title=Most+Popular&amp;more_url=&amp;video_ids=PIVtr5kYvmU%2Crc9sQYIZhAQ%2C7mBu2AFaYR4%2CCyWZB8TsVXk" class="yt-uix-button  shelves-play yt-uix-sessionlink yt-uix-button-default yt-uix-button-size-small" data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg"><span class="yt-uix-button-icon-wrapper"><img class="yt-uix-button-icon yt-uix-button-icon-play-all" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></span><span class="yt-uix-button-content">Play </span></a>

  </h2>


      <div class="lohp-vertical-shelf-item context-data-item" data-context-item-type="video" data-context-item-views="237,525 views" data-context-item-title="ZOMBIE GIRLFRIEND ATTACK" data-context-item-time="7:40" data-context-item-user="BFvsGF" data-context-item-id="PIVtr5kYvmU">
        <div class="lohp-media-object ">
          <a href="/watch?v=PIVtr5kYvmU" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFQQzx4oAA">    <span class="video-thumb  yt-thumb yt-thumb-64"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/PIVtr5kYvmU/default.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="64" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">7:40</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="PIVtr5kYvmU" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
        </div>
        <div class="lohp-vertical-shelf-item-content lohp-media-object-content">
            <a class="lohp-video-link max-line-3 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFQQzx4oAA"
     href="/watch?v=PIVtr5kYvmU"
     title="ZOMBIE GIRLFRIEND ATTACK">ZOMBIE GIRLFRIEND ATTACK</a>

          <div class="lohp-video-metadata attached">
              <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/BFvsGF" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UCqIqRzEge-Qvt4Iglx-uKdQ" data-name="">BFvsGF</a>
  </span>

          </div>
        </div>
      </div>
      <div class="lohp-vertical-shelf-item context-data-item" data-context-item-type="video" data-context-item-views="392,662 views" data-context-item-title="Bizkit the Guilty dog walking" data-context-item-time="0:21" data-context-item-user="ploophugs" data-context-item-id="rc9sQYIZhAQ">
        <div class="lohp-media-object ">
          <a href="/watch?v=rc9sQYIZhAQ" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFYQzx4oAQ">    <span class="video-thumb  yt-thumb yt-thumb-64"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/rc9sQYIZhAQ/default.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="64" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">0:21</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="rc9sQYIZhAQ" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
        </div>
        <div class="lohp-vertical-shelf-item-content lohp-media-object-content">
            <a class="lohp-video-link max-line-3 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFYQzx4oAQ"
     href="/watch?v=rc9sQYIZhAQ"
     title="Bizkit the Guilty dog walking">Bizkit the Guilty dog walking</a>

          <div class="lohp-video-metadata attached">
              <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/ploophugs" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UCieSLcCzpqgBAfqltBGcXwQ" data-name="">ploophugs</a>
  </span>

          </div>
        </div>
      </div>
      <div class="lohp-vertical-shelf-item context-data-item" data-context-item-type="video" data-context-item-views="175,258 views" data-context-item-title="HOW TO PISS OFF YOUR WIFE LOL!  (10.9.13 - Day 1623)" data-context-item-time="9:01" data-context-item-user="CTFxC" data-context-item-id="7mBu2AFaYR4">
        <div class="lohp-media-object ">
          <a href="/watch?v=7mBu2AFaYR4" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFgQzx4oAg">    <span class="video-thumb  yt-thumb yt-thumb-64"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/7mBu2AFaYR4/default.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="64" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">9:01</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="7mBu2AFaYR4" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
        </div>
        <div class="lohp-vertical-shelf-item-content lohp-media-object-content">
            <a class="lohp-video-link max-line-3 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFgQzx4oAg"
     href="/watch?v=7mBu2AFaYR4"
     title="HOW TO PISS OFF YOUR WIFE LOL!  (10.9.13 - Day 1623)">HOW TO PISS OFF YOUR WIFE LOL!  (10.9.13 - Day 1623)</a>

          <div class="lohp-video-metadata attached">
              <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/CTFxC" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UCvphW8g3rf4m8LnOarxpU1A" data-name="">CTFxC</a>
  </span>

          </div>
        </div>
      </div>
      <div class="lohp-vertical-shelf-item context-data-item" data-context-item-type="video" data-context-item-views="409,330 views" data-context-item-title="Real Friends 2" data-context-item-time="4:14" data-context-item-user="Wong Fu Productions" data-context-item-id="CyWZB8TsVXk">
        <div class="lohp-media-object ">
          <a href="/watch?v=CyWZB8TsVXk" class="ux-thumb-wrap yt-uix-sessionlink yt-uix-contextlink contains-addto lohp-thumb-wrap"  data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFoQzx4oAw">    <span class="video-thumb  yt-thumb yt-thumb-64"
      >
      <span class="yt-thumb-default">
        <span class="yt-thumb-clip">
          <span class="yt-thumb-clip-inner">
            <img data-thumb="//i1.ytimg.com/vi/CyWZB8TsVXk/default.jpg" src="http://s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Thumbnail" width="64" >
            <span class="vertical-align"></span>
          </span>
        </span>
      </span>
    </span>
<span class="video-time">4:14</span>

  <button title="Watch Later" onclick=";return false;" class="addto-button video-actions spf-nolink addto-watch-later-button-sign-in yt-uix-button yt-uix-button-default yt-uix-button-size-small yt-uix-tooltip" type="button" data-video-ids="CyWZB8TsVXk" data-button-menu-id="shared-addto-watch-later-login" role="button"><span class="yt-uix-button-content">  <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Watch Later">
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>
</a>
        </div>
        <div class="lohp-vertical-shelf-item-content lohp-media-object-content">
            <a class="lohp-video-link max-line-3 yt-uix-sessionlink "
     data-sessionlink="feature=g-logo&amp;ei=xzlYUsTgGamP8gH_q4GACg&amp;ved=CFoQzx4oAw"
     href="/watch?v=CyWZB8TsVXk"
     title="Real Friends 2">Real Friends 2</a>

          <div class="lohp-video-metadata attached">
              <span class="content-uploader spf-nolink">
<span class="username-prepend">by</span> <a href="/user/WongFuProductions" class="g-hovercard yt-uix-sessionlink yt-user-name " data-sessionlink="ei=xzlYUsTgGamP8gH_q4GACg" dir="ltr" data-ytid="UCutXfzLC5wrV3SInT_tdY0w" data-name="">Wong Fu Productions</a>  <span class="yt-user-name-icon-verified">
    <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" class="yt-uix-tooltip yt-channel-title-icon-verified" alt="" title="Verified name">
  </span>

  </span>

          </div>
        </div>
      </div>
  </div>

  </div>

  <div style="clear:both;"></div>



    </div>
  <div id="footer-ads">
            


  <div id="ad_creative_3" class="ad-div " style="z-index: 1">
      <iframe id="ad_creative_iframe_3" height="1" width="1" scrolling="no" frameborder="0" style="z-index: 1"></iframe>
        <script>
    (function() {
      function tagMpuIframe() {
            var adIframe = document.getElementById("ad_creative_iframe_3");
            if (!adIframe) {
              return;
            }
            var ord = Math.floor(Math.random() * 10000000000000000);
            adIframe.src = "http://ad.doubleclick.net/N6762/adi/mkt.ythome_1x1/;sz=1x1;tile=3;dc_yt=1;kga=-1;kgg=-1;klg=en;kmyd=ad_creative_3;ord=" + ord + "?";
      }

       tagMpuIframe();
    })();
  </script>

  </div>


  </div>

  </div>

      </div>
    </div>
  </div>
</div></div></div></div><div id="footer-container" class="yt-base-gutter"><div id="footer"><div id="footer-main"><div id="footer-logo"><a href="/" title="YouTube home"><img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="YouTube home"></a></div>  <ul class="pickers yt-uix-button-group" data-button-toggle-group="optional">
      <li>
          
  <button id="yt-picker-language-button" class=" yt-uix-button yt-uix-button-default yt-uix-button-size-default yt-uix-button-has-icon" onclick=";return false;" type="button" data-button-menu-id="arrow-display" data-picker-key="language" data-button-action="yt.www.picker.load" data-picker-position="footer" data-button-toggle="true" role="button"><span class="yt-uix-button-icon-wrapper"><img class="yt-uix-button-icon yt-uix-button-icon-footer-language" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></span><span class="yt-uix-button-content">  <span class="yt-picker-button-label">
Language:
  </span>
  English
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>


      </li>
      <li>
          
  <button id="yt-picker-country-button" class=" yt-uix-button yt-uix-button-default yt-uix-button-size-default" onclick=";return false;" type="button" data-button-menu-id="arrow-display" data-picker-key="country" data-button-action="yt.www.picker.load" data-picker-position="footer" data-button-toggle="true" role="button"><span class="yt-uix-button-content">  <span class="yt-picker-button-label">
Country:
  </span>
  Canada
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>


      </li>
      <li>
          
  <button id="yt-picker-safetymode-button" class=" yt-uix-button yt-uix-button-default yt-uix-button-size-default" onclick=";return false;" type="button" data-button-menu-id="arrow-display" data-picker-key="safetymode" data-button-action="yt.www.picker.load" data-picker-position="footer" data-button-toggle="true" role="button"><span class="yt-uix-button-content">  <span class="yt-picker-button-label">
Safety:
  </span>
Off
 </span><img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""></button>


      </li>
  </ul>
  <button class="yt-uix-button-reverse yt-google-help-link yt-uix-button yt-uix-button-default yt-uix-button-size-default" onclick=";return false;" data-ghelp-anchor="google-help" id="google-help" type="button"  role="button"><span class="yt-uix-button-content">  <img class="questionmark" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif">
  <span>Help</span>
    <img class="yt-uix-button-arrow" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif">
 </span></button>
      <div id="yt-picker-language-footer"
      class="yt-picker"
      style="display: none"
>
      <p class="yt-spinner">
      <img class="yt-spinner-img" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Loading icon
" title="">

    <span class="yt-spinner-message">
Loading...
    </span>
  </p>

  </div>

      <div id="yt-picker-country-footer"
      class="yt-picker"
      style="display: none"
>
      <p class="yt-spinner">
      <img class="yt-spinner-img" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Loading icon
" title="">

    <span class="yt-spinner-message">
Loading...
    </span>
  </p>

  </div>

      <div id="yt-picker-safetymode-footer"
      class="yt-picker"
      style="display: none"
>
      <p class="yt-spinner">
      <img class="yt-spinner-img" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Loading icon
" title="">

    <span class="yt-spinner-message">
Loading...
    </span>
  </p>

  </div>

</div><div id="footer-links"><ul id="footer-links-primary">  <li><a href="//www.youtube.com/yt/about/">About</a></li>
  <li><a href="//www.youtube.com/yt/press/">Press &amp; Blogs</a></li>
  <li><a href="//www.youtube.com/yt/copyright/">Copyright</a></li>
  <li><a href="//www.youtube.com/yt/creators/">Creators &amp; Partners</a></li>
  <li><a href="//www.youtube.com/yt/advertise/">Advertising</a></li>
  <li><a href="//www.youtube.com/yt/dev/">Developers</a></li>
</ul><ul id="footer-links-secondary">  <li><a href="/t/terms">Terms</a></li>
  <li><a href="http://www.google.com/intl/en/policies/privacy/">Privacy</a></li>
  <li><a href="//www.youtube.com/yt/policyandsafety/">
Policy &amp; Safety
  </a></li>
  <li><a href="//www.google.com/tools/feedback/intl/en/error.html" onclick="return yt.www.feedback.start(59);" class="reportbug">Send feedback</a></li>
  <li><a href="/testtube">Try something new!</a></li>
  <li>  <span class="copyright" dir="ltr">&copy; 2013 YouTube, LLC</span>
</li>
</ul></div></div></div>

      <div class="yt-dialog hid" id="feed-privacy-lb">
    <div class="yt-dialog-base">
      <span class="yt-dialog-align"></span>
      <div class="yt-dialog-fg">
        <div class="yt-dialog-fg-content">
          <div class="yt-dialog-loading">
              <div class="yt-dialog-waiting-content">
    <div class="yt-spinner-img"></div><div class="yt-dialog-waiting-text">Loading...</div>
  </div>

          </div>
          <div class="yt-dialog-content">
              <div id="feed-privacy-dialog">
  </div>

          </div>
          <div class="yt-dialog-working">
              <div id="yt-dialog-working-overlay">
  </div>
  <div id="yt-dialog-working-bubble">
    <div class="yt-dialog-waiting-content">
      <div class="yt-spinner-img"></div><div class="yt-dialog-waiting-text">Working...</div>
    </div>
  </div>

          </div>
        </div>
      </div>
    </div>
  </div>



    <div id="shared-addto-watch-later-login" class="hid">
      <a href="https://accounts.google.com/ServiceLogin?uilel=3&service=youtube&hl=en&passive=true&continue=http%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26app%3Ddesktop%26feature%3Dplaylist%26hl%3Den%26next%3D%252F" class="sign-in-link">Sign in</a> to add this to Watch Later

    </div>

  <div id="shared-addto-menu" style="display: none;" class="hid sign-in">
      <div class="addto-menu">
        <div id="addto-list-panel" class="menu-panel active-panel">
          <span class="addto-playlist-item yt-uix-button-menu-item yt-uix-tooltip sign-in"
        data-possible-tooltip=""
        data-tooltip-show-delay="750"



>
<img class="playlist-status" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="" title=""><a href="https://accounts.google.com/ServiceLogin?uilel=3&service=youtube&hl=en&passive=true&continue=http%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26app%3Ddesktop%26feature%3Dplaylist%26hl%3Den%26next%3D%252F" class="sign-in-link">Sign in</a> to add this to Watch Later
  </span>


  </div>
  <div id="addto-list-saving-panel" class="menu-panel">
    <div class="addto-loading loading-content">
        <p class="yt-spinner">
      <img class="yt-spinner-img" src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif" alt="Loading icon
" title="">

    <span class="yt-spinner-message">
        Loading playlists...
    </span>
  </p>

    </div>
  </div>
  <div id="addto-list-error-panel" class="menu-panel">
    <div class="panel-content">
      <img src="//s.ytimg.com/yts/img/pixel-vfl3z5WfW.gif">
      <span class="error-details"></span>
      <a class="show-menu-link">Back to list</a>
    </div>
  </div>

  </div>

  </div>
<script>if (window.ytcsi) {window.ytcsi.tick("hr", null, '');}</script><script>var ytspf = ytspf || {};ytspf.enabled = false;</script>  <script id="js-2897685604" class="spf" src="//s.ytimg.com/yts/jsbin/spf-vflFsej--.js" data-loaded="true"></script>
  <script id="js-2023136720" class="www_base_mod" src="//s.ytimg.com/yts/jsbin/www-vfl5g1cC4/www_base_mod.js" data-loaded="true"></script>
<script>if (window.ytcsi) {window.ytcsi.tick("je", null, '');}</script>    <script>
  </script>




  <script>
      yt.setAjaxToken('feed_change_ajax', "cKUygfzkmwZ8_FJKoestAz_Etjx8MTM4MTYwMDA3MUAxMzgxNTEzNjcx");


      yt.setConfig({
        'PYV_IFRAME_CONTENT': "\u003cscript\u003ewindow.yt = window.yt || {};yt.www = yt.www || {};yt.www.home = yt.www.home || {};yt.www.home.ads = yt.www.home.ads || {};window.renderHomepagePyv = function(pyv) {writePyvAd();};\u003c\/script\u003e\u003cscript\u003evar renderPyvCallback = parent.yt.www.ads.pyv.pyvHomeAfcCallback;window.writePyvAd = function() {window['google_page_url'] = parent.document.location;window['google_language'] = \"en\";window['google_loeid'] = \"936100\";window['google_ad_client'] = \"ca-pub-6219811747049371\";window['google_ad_channel'] = \"pyvhome+hitchhiker+pyv-top-right-homepage+pyv-top-right-homepage-us+logged-out+pyvhomeinshelf\";window['google_max_num_ads'] = 1;window['google_ad_output'] = 'js';window['google_ad_type'] = 'text';window['google_only_pyv_ads'] = true;window['google_ad_request_done'] = function(googleAds) {renderPyvCallback(googleAds);};document.write('\u003cscript s\u0072c=\"\/\/pagead2.googlesyndication.com\/pagead\/show_ads.js\"\u003e\u003c\\\/script\u003e');};var pyvCallback = window.renderHomepagePyv;pyvCallback();\u003c\/script\u003e",
        'PYV_IFRAME_ID': "pyv-iframe"
      });






    yt.setConfig('JS_PAGE_MODULES', {
      "\/\/s.ytimg.com\/yts\/jsbin\/www-vfl5g1cC4\/www_feed_mod.js": []
    });
  </script>


  <script>
      yt.setConfig({
        'GUIDE_SELECTED_ITEM': "HCr0DkU4jyKZg"
      });
  </script>
<script>yt.setConfig({'EVENT_ID': "xzlYUsTgGamP8gH_q4GACg",'PAGE_NAME': "index",'LOGGED_IN': false,'SESSION_INDEX': null,'DELEGATED_SESSION_ID': null,'GAPI_HOST': "https:\/\/apis.google.com",'GAPI_HINT_PARAMS': "m;\/_\/scs\/abc-static\/_\/js\/k=gapi.gapi.en.RmzQ7mCRk5g.O\/m=__features__\/rt=j\/d=1\/rs=AItRSTOhEFqYZgveL6cKOKjO75yirdM_0w",'GAPI_LOCALE': "en_US",'GOOGLEPLUS_HOST': "https:\/\/plus.google.com",'MASTHEAD_JS': "\/\/s.ytimg.com\/yts\/jsbin\/www-masthead-vfla9-l3T.js",'JS_COMMON_MODULE': "\/\/s.ytimg.com\/yts\/jsbin\/www-vfl5g1cC4\/www_common_mod.js",'SAFETY_MODE_PENDING': false,'LOCAL_DATE_TIME_CONFIG': {"formatLongDate": "MMMM d, yyyy h:mm a", "formatWeekdayShortTime": "EE h:mm a", "formatLongDateOnly": "MMMM d, yyyy", "shortWeekdays": ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"], "weekdays": ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"], "shortMonths": ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"], "amPms": ["AM", "PM"], "formatShortDate": "MMM d, yyyy", "months": ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"]},'PAGE_CL': 54033354,'PAGE_BUILD_TIMESTAMP': "Wed Oct  9 19:31:46 2013 (1381372306)",'UNIVERSAL_HOVERCARDS': true,'FEEDBACK_BUCKET_ID': "Home",'FEEDBACK_LOCALE_LANGUAGE': "en",'FEEDBACK_LOCALE_EXTRAS': {"accept_language": null, "experiments": "936100,924606,924616,924610,916914,925724,936401,906945,929935,929937,929939,939602,939604,906842,920605,912715,919811,935704,911504,934003,934004,931924,938608,913578,940501,934803,936308,935006,939201,900816,912711,934507,912714,907231,930635,936312,906001", "is_partner": "", "logged_in": false, "is_branded": "", "guide_subs": "NA"}});yt.setMsg({'ADDTO_WATCH_LATER': "Watch Later",'ADDTO_WATCH_LATER_ADDED': "Added",'ADDTO_WATCH_LATER_ERROR': "Error"});yt.setAjaxToken('addto_ajax_logged_out', "QNbufLeljNh3EeytL2Shb5mewzZ8MTM4MTYwMDA3MUAxMzgxNTEzNjcx");  yt.setConfig('FEED_PRIVACY_CSS_URL', "http:\/\/s.ytimg.com\/yts\/cssbin\/www-feedprivacydialog-vflqVBvKm.css");
  yt.setAjaxToken('feed_privacy_ajax', "Y1eWNhZ_neU3ZhBmA7M2T_SLx658MTM4MTYwMDA3MUAxMzgxNTEzNjcx");
    yt.setConfig('FEED_PRIVACY_LIGHTBOX_ENABLED', true);
yt.setConfig({'SBOX_JS_URL': "\/\/s.ytimg.com\/yts\/jsbin\/www-searchbox-vflhXofYS.js",'SBOX_SETTINGS': {"REQUEST_DOMAIN": "ca", "EXPERIMENT_ID": -1, "SHOW_CHIP": false, "CLOSE_ICON_URL": "\/\/s.ytimg.com\/yts\/img\/icons\/close-vflrEJzIW.png", "CHIP_PARAMETERS": {}, "USE_HTTPS": false, "PSUGGEST_TOKEN": null, "SESSION_INDEX": null, "HAS_ON_SCREEN_KEYBOARD": false, "REQUEST_LANGUAGE": "en"},'SBOX_LABELS': {"WATCH_NOW_LABEL": "Watch now", "VIEW_CHANNEL_LABEL": "View channel", "SUGGESTION_DISMISSED_LABEL": "Suggestion dismissed", "SUGGESTION_DISMISS_LABEL": "Dismiss"}});  yt.setConfig({
    'YPC_LOADER_ENABLED': true,
    'YPC_LOADER_CONFIGS': "\/ypc_config_ajax",
    'YPC_LOADER_JS': "\/\/s.ytimg.com\/yts\/jsbin\/www-ypc-vflolo6Bj.js",
    'YPC_LOADER_CSS': "http:\/\/s.ytimg.com\/yts\/cssbin\/www-ypc-vfl7OlCUa.css",
    'YPC_LOADER_CALLBACKS': ['yt.www.ypc.checkout.init', 'yt.www.ypc.subscription.init']
  });
  yt.setConfig('GOOGLE_HELP_CONTEXT', "homepage");
</script>    <script>
ytcsi.span('st', 135);yt.setConfig({'TIMING_ACTION': "glo",'TIMING_INFO': {"yt_spf": 0, "ei": "xzlYUsTgGamP8gH_q4GACg", "yt_lt": "cold", "yt_li": 0, "e": "936100"}});    </script>
<script>yt.setConfig({'XSRF_TOKEN': "t7lze3_GGWnKEATOoCsqWc26ugp8MTM4MTYwMDA3MUAxMzgxNTEzNjcx",'XSRF_REDIRECT_TOKEN': "mu7oMYqtsEhsMubkfmdPtmFILKN8MTM4MTYwMDA3MUAxMzgxNTEzNjcx",'XSRF_FIELD_NAME': "session_token"});</script><script>yt.setConfig('THUMB_DELAY_LOAD_BUFFER', 300);</script><script>if (window.ytcsi) {window.ytcsi.tick("jl", null, '');}</script>  <div id="debug"></div>
</body></html>
