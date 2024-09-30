namespace SessionStorage.Repositories;

public class SessionRepository : ISessionRepository
{
	public async Task InitSessionAsync(ISessionStorageService sessionStorageService, Guid userId)
	{
		Session session = new Session();
		session.Id = userId;
		await sessionStorageService.SetItemAsync("sessionInfo", session);
	}
	public async Task<Session> GetSessionAsync(ISessionStorageService sessionStorageService)
	{
		Session session;
		session = await sessionStorageService.GetItemAsync<Session>("sessionInfo");
		return session ?? new Session();
	}

	public Guid GetSessionId(ISessionStorageService sessionStorageService)
	{
		throw new NotImplementedException();
	}

	public Guid GetSessionUserId(ISessionStorageService sessionStorageService)
	{
		throw new NotImplementedException();
	}


}
