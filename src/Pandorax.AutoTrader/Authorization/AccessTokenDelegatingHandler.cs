using System.Net.Http.Headers;

namespace Pandorax.AutoTrader.Authorization;

/// <summary>
/// A request interceptor which handles adding access tokens to outgoing requests.
/// </summary>
internal class AccessTokenDelegatingHandler : DelegatingHandler
{
    private readonly AccessTokenHandler _accessTokenHandler;

    public AccessTokenDelegatingHandler(AccessTokenHandler accessTokenHandler)
    {
        _accessTokenHandler = accessTokenHandler;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        string token = await _accessTokenHandler.GetAccessTokenAsync();

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

        return await base.SendAsync(request, cancellationToken);
    }
}
